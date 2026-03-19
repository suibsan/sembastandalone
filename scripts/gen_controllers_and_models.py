from argparse import ArgumentParser
from collections import defaultdict
from pathlib import Path
import re

from generator import gen_controller_and_model, gen_model_constructor

def main():
    parser = ArgumentParser()
    parser.add_argument("signatures_csv")
    parser.add_argument("controllers_out", type=Path)
    parser.add_argument("models_out", type=Path)
    args = parser.parse_args()

    with open(args.signatures_csv, "r", encoding="utf-8") as f:
        lines = re.findall(r"([^\n]+)", f.read())
        signatures = map(lambda x: x.split(","), lines)
        signatures = list(signatures)
    
    controllers = defaultdict(list)
    models = defaultdict(list)

    for method_name, req_type, res_type in signatures:
        class_ = method_name.split("_")[0]
        _, controller, model = gen_controller_and_model(method_name, req_type, res_type)

        controllers[class_].append(controller)
        models[class_].append(model)

    args.controllers_out.mkdir(exist_ok=True)
    args.models_out.mkdir(exist_ok=True)

    for class_, controller_methods in controllers.items():
        with open(args.controllers_out/f"{class_}Controller.cs", "w", encoding="utf-8") as f:
            write_controller(f, class_, controller_methods)
        
        model_methods = models[class_]

        model_methods.append(gen_model_constructor(class_))

        with open(args.models_out/f"{class_}Model.cs", "w", encoding="utf-8") as f:
            write_model(f, class_, model_methods)


def write_controller(f, class_, controller_methods):
    f.write(f"""
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class {class_}Controller : Controller {{

private {class_}Model model;

public {class_}Controller(ISembaWrapper wrapper) {{
    model = new {class_}Model(wrapper);
}}

{"\n".join(controller_methods)}
}}
""")

def write_model(f, class_, model_methods):
    f.write(f"""
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class {class_}Model {{
{"\n".join(model_methods)}
}}
""")
             

if __name__ == "__main__":
    main()