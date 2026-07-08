from argparse import ArgumentParser 
import time

import requests

# Path: /battle/start
# Battle_Start: { "battleEntryIds": [ 2009457, 2009454 ], "lineCharacterIds": [ 101101, 100801, 100201 ], "battleTriggers": [ { "triggerIds": [ 100201703, 100201702 ] } ], "advantageType": "advantage", "isAttackHit": true, "currentLocation": { "areaType": 1, "direction": 8, "positionCoordinates": { "x": -17.106472, "y": 0.012497902, "z": -5.2582445 }, "areaKeyId": 100201 }, "bloodStainLocation": { "areaKeyId": 100201, "areaType": 1, "positionCoordinates": { "x": -14.798237, "y": 0.012497902, "z": -4.0950985 } } }
battleStartReqHex = "48FB903D3FED2BD255CFBB49247BE1CFBFF15723DEF1EEDBC01A0009DD9694AF2A18B9BF960CF9B76EBAAC0374DAF0D5F6CA58D0B909D445B1A64C2C26004F9984FB66F45414F440DDC9CD5A06579B5E99E4398E49CEA36C3DE4D803DC40B35FF1"

# Path: /battle/finish ==26788==ERROR: AddressSanitizer:
# Battle_Finish: { "characterUpdates": [ { "characterId": 101101, "hp": 857 }, { "characterId": 100801, "hp": 817 }, { "characterId": 100201, "hp": 939 } ], "battleTaskTopics": [ { "type": "qte", "count": 4 }, { "type": "heal_hp", "count": 66 }, { "type": "special_attack", "count": 1 } ], "encounteredEnemyIds": [ 209104, 209103, 252101, 250101 ], "battleTimeSecond": 38, "taskConditionResult": { "usedSkills": [ { "characterSkillId": 1011016, "count": 2 }, { "characterSkillId": 1008016, "count": 1 }, { "characterSkillId": 1002016, "count": 1 }, { "characterSkillId": 1002014, "count": 1 } ], "enemyStabilityBreaks": [ { "enemyId": 209103, "count": 1 }, { "enemyId": 250101, "count": 1 } ] } }
battleFinishReqHex = "BA5B341A07BC2EAB5FBDF13CFF2593BD07C980604EB51E7E02D8D0BD1216397692342F02656B952228524C8ACE3E67A3E8D9AA09776803EEE3953FB264763357AFE7378060A3FB8A17C07619E407C933C27A5E32EF5DDF555B6469B73EBD0D6BA4499311C1F17DE9206E1EF3E20A73367F"


def post(base_url, path, data):
    res = requests.post(f"{base_url}{path}", data=bytes.fromhex(data))
    print(base_url, path, res.status_code) 
    return res.content.hex()

def post_args(args):
    post(*args)

def battle_start(base_url):
    post(base_url, "/battle/start", battleStartReqHex)

def battle_finish(base_url):
    post(base_url, "/battle/finish", battleFinishReqHex)

def reset_db(base_url):
    post(base_url, "/semba/reset_db", "")

def main():
    parser = ArgumentParser()
    parser.add_argument("base_url")
    args = parser.parse_args()

    # reset_db(args.base_url)
    battle_start(args.base_url)
    t = 60
    print(f"Waiting {t} seconds...")
    time.sleep(t)

    battle_finish(args.base_url)

    # heap-use-after-free on address 0x7d7fd4543968 at pc 0x7acea0278e01 bp 0x7acea4a200b0 sp 0x7acea4a200a8
    # READ of size 8 at 0x7d7fd4543968 thread T57
    #     #0 0x7acea0278e00 in addToSharedFreeList__system_u7034
    #     #1 0x7acea0283efb in rawDealloc__system_u7339
    #     #2 0x7acea02842eb in dealloc__system_u7422 (libsemba.so+0x18842eb)
    #     #3 0x7acea02891a6 in deallocImpl__system_u1775 (libsemba.so+0x18891a6)
    #     #4 0x7acea02891c5 in deallocSharedImpl__system_u1788 (libsemba.so+0x18891c5)
    #     #5 0x7acea02891e0 in deallocShared (libsemba.so+0x18891e0)
    #     #6 0x7acea0289207 in alignedDealloc (libsemba.so+0x1889207)
    #     #7 0x7acea04c3206 in eqdestroy___sembaZmodel95stableZadventure95variable_u74 (libsemba.so+0x1ac3206)
    #     #8 0x7acea0377b70 in eqsink___sembaZapi95stableZbattle_u815 (libsemba.so+0x1977b70)
    #     #9 0x7acea0c62c14 in battle_Finish__sembaZapi95stableZbattle_u1047 (libsemba.so+0x2262c14)
    #     #10 0x7acea0d62468 in getJsonResultStable__sembaZsembastable_u26 (libsemba.so+0x2362468)
    #     #11 0x7acea0e584a3 in sembaExCallImpl__semba_u46 (libsemba.so+0x24584a3)
    #     #12 0x7acea0e5ad88 in SembaExCall (libsemba.so+0x245ad88)
    #     #13 0x7b0f589c8a0c  (<unknown module>)
    
    print("OK")


if __name__ ==  "__main__":
    main()
