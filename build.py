import argparse
import pathlib
import subprocess

def run(cmd):
    print(cmd)
    return subprocess.run(cmd)

def main():
    semba_path = pathlib.Path("semba")
    dotnet_publish_path = pathlib.Path("bin/Release/net9.0/publish")

    if not semba_path.exists():
        run(["git", "clone", "git@github.com:/24tribe/semba.git", "semba"])
    else:
        run(["git", "-C", str(semba_path), "fetch", "origin", "master"])
        run(["git", "-C", str(semba_path), "reset", "--hard", "origin/master"])

    semba_build_path = pathlib.Path("bin/semba_build")

    if not semba_build_path.exists():
        run(["meson", "setup", "-Ddefault_library=shared", str(semba_build_path), str(semba_path)])

    run(["meson", "compile", "-C", str(semba_build_path)])

    run(["dotnet", "publish"])

    run(["cp", str(semba_build_path/"semba.db"), str(dotnet_publish_path)])

    run(["cp", str(semba_build_path/"libsemba.dll"), str(dotnet_publish_path)])

if __name__ == "__main__":
    main()