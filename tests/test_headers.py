from check_bug import reset_db, post, parse_args


def main():
    args = parse_args()

    reset_db(args.base_url).raise_for_status()

    res = post(args.base_url, "/user/log_in", "", headers={
        "X-platform": "android",
        "X-master-data-version": "1754991108_eZMAZkXEu2j4eKRs",
        "X-asset-version": "dummy",
    })

    assert res.headers["X-Server-Timestamp"] == "0"
    assert res.status_code == 409
    assert res.json() == {
        "asset_version": "1751522506_6r3dz52c5q_2zJrU",
        "code": "requires_assets_updates"
    }

    print("OK")


if __name__ == "__main__":
    main()
