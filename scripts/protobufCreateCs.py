from argparse import ArgumentParser
from pathlib import Path
import re

from protobufDump import parse_class

def main():
    parser = ArgumentParser()
    parser.add_argument("neon_model_api_rpc_src_dir", type=Path)
    parser.add_argument("neon_model_api_model_src_dir", type=Path)
    parser.add_argument("out_rpc_dir", type=Path)
    parser.add_argument("out_model_dir", type=Path)
    args = parser.parse_args()

    args.out_rpc_dir.mkdir(exist_ok=True)
    args.out_model_dir.mkdir(exist_ok=True)

    rpc_classes = parse_classes(args.neon_model_api_rpc_src_dir)
    model_classes = parse_classes(args.neon_model_api_model_src_dir)

    write_classes(rpc_classes, "Neon.Model.Api.Rpc", args.out_rpc_dir)
    write_classes(model_classes, "Neon.Model.Api.Model", args.out_model_dir)
    print("OK")


def write_classes(classes, ns, out_dir):
    for class_ in classes:
        code = gen_cs(ns, class_)
        with open(out_dir/f"{class_["class_name"]}.cs", "w", encoding="utf-8") as f:
            f.write(code)

inner_type_regex = re.compile(r"RepeatedField<([^>]+)>")

def gen_cs(ns, class_):
    lines = []
    lines.append(f"""
namespace {ns};

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class {class_['class_name']} {{""")

    for field in class_["fields"]:
        type_ = field["type"]
        match = inner_type_regex.search(type_)
        if match:
            type_ = f"{match.group(1)}[]"

        if type_ == "Timestamp":
            type_ = "DateTime?"

        lines.append(f"    [ProtoMember({field['proto_field_num']})]")
        lines.append(f"    public required {type_} {field["field_name"]} {{ get; set; }}\n")

    lines.append("}")

    return "\n".join(lines)


def parse_classes(dir_):
    classes = []

    for path in dir_.glob("*.cs"):
        if "Reflection.cs" in str(path):
            continue

        with open(path, "r", encoding="utf-8") as f:
            content = f.read()

        if not "IMessage<" in content:
            continue

        try:
            classes.append(parse_class(content))
        except:
            print(f"{path}")
            raise

    return classes

if __name__ == "__main__":
    main()