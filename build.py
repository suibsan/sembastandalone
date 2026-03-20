from argparse import ArgumentParser
import pathlib
import subprocess
import platform

SEMBA_LIB_FILENAME = "libsemba.dll" if platform.system() == "Windows" else "libsemba.so"

def run(cmd):
    print(cmd)
    return subprocess.run(cmd, check=True)

def main():
    parser = ArgumentParser()

    parser.add_argument("--branch", default="master")
    args = parser.parse_args()

    semba_path = pathlib.Path("semba")
    dotnet_publish_path = pathlib.Path("bin/Release/net9.0/publish")

    if not semba_path.exists():
        run(["git", "clone", "git@github.com:/24tribe/semba.git", "semba"])
    else:
        run(["git", "-C", str(semba_path), "fetch", "origin", args.branch])
        run(["git", "-C", str(semba_path), "reset", "--hard", f"origin/{args.branch}"])

    semba_build_path = pathlib.Path("bin/semba_build")

    if not semba_build_path.exists():
        run(["meson", "setup", "-Ddefault_library=shared", str(semba_build_path), str(semba_path)])

    run(["meson", "compile", "-C", str(semba_build_path)])

    run(["dotnet", "publish"])

    run(["cp", str(semba_build_path/"semba.db"), str(dotnet_publish_path)])

    run(["cp", str(semba_build_path/SEMBA_LIB_FILENAME), str(dotnet_publish_path)])

if __name__ == "__main__":
    main()