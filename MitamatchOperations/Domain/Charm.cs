﻿using System;
using System.IO;
using mitama.Domain;

namespace MitamatchOperations.Domain;

public record Charm(
    string Name,
    string Ability,
    Status Status,
    DateOnly Date
)
{
    public Uri Uri => new($"ms-appx:///Assets/charm/{Name}.png");
    public string Path = $"/Assets/charm/{Name}.png";

    public static readonly Charm[] List = [
        new Charm(
            "ティルフィングSP.TS",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(13000, 20800, 13000, 18200),
            new(2023, 11, 30)
        ),
        new Charm(
            "Hi-タンキエム",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(20800, 20800, 11700, 11700),
            new(2023, 11, 30)
        ),
        new Charm(
            "レムの花飾り",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(23400, 9100, 23400, 9100),
            new(2023, 11, 3)
        ),
        new Charm(
            "ラムの花飾り",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(23400, 10400, 20800, 10400),
            new(2023, 11, 3)
        ),
        new Charm(
            "エミリアのペンダント",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(9100, 26000, 9100, 20800),
            new(2023, 10, 31)
        ),
        new Charm(
            "レムの鉄球",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(26000, 9100, 20800, 9100),
            new(2023, 10, 31)
        ),
        new Charm(
            "ラムの杖",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(11700, 22100, 11700, 19500),
            new(2023, 10, 31)
        ),
        new Charm(
            "エミリアのペンダント(エミリアのローブ)",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(22100, 11700, 19500, 11700),
            new(2023, 10, 31)
        ),
        new Charm(
            "シャルルマーニュSP.RS(Ver3)",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(24700, 12350, 15600, 12350),
            new(2023, 10, 22)
        ),
        new Charm(
            "グングニルカービンSP.IF(Ver2)",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2023, 10, 12)
        ),
        new Charm(
            "フラガラッハFC-01",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.ATKが大アップする。",
            new(19500, 19500, 13000, 13000),
            new(2023, 10, 11)
        ),
        new Charm(
            "マルミアドワーズFC-01",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/DEFが大アップする。",
            new(20800, 11700, 19500, 13000),
            new(2023, 10, 11)
        ),
        new Charm(
            "コルブランドFC-01",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATK/Sp.DEFが大アップする。",
            new(11700, 20800, 13000, 19500),
            new(2023, 10, 11)
        ),
        new Charm(
            "アロンダイトFC-01",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のDEF/Sp.DEFが大ダウンする。",
            new(12350, 12350, 20150, 20150),
            new(2023, 10, 11)
        ),
        new Charm(
            "キャリバーンFC-01",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.ATKが大アップする。",
            new(20800, 20800, 11700, 11700),
            new(2023, 10, 11)
        ),
        new Charm(
            "デュランダルSP.HY",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(20800, 13000, 18200, 13000),
            new(2023, 9, 30)
        ),
        new Charm(
            "グラムMCCブースト",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(13000, 20800, 13000, 18200),
            new(2023, 9, 30)
        ),
        new Charm(
            "モンドラゴンSP.KH",
            "メモリアスキル効果UP+10%。メモリア使用時、それが風属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(10000, 20000, 10000, 10000),
            new(2023, 9, 10)
        ),
        new Charm(
            "黒子の金属矢(メイドスタイル)",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(19000, 7000, 17000, 7000),
            new(2023, 9, 3)
        ),
        new Charm(
            "美琴のコイン(ドリーミングアイドル)",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のSp.ATK/Sp.DEFが大アップする。",
            new(7000, 18500, 7000, 17500),
            new(2023, 9, 3)
        ),
        new Charm(
            "黒子の金属矢(ドリーミングアイドル)",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/Sp.ATKが大アップする。",
            new(18000, 18000, 7000, 7000),
            new(2023, 9, 3)
        ),
        new Charm(
            "食蜂のリモコン(ドリーミングアイドル)",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/DEFが大アップする。",
            new(18500, 7000, 17500, 7000),
            new(2023, 9, 3)
        ),
        new Charm(
            "美琴のコイン",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(20000, 7000, 16000, 7000),
            new(2023, 8, 31)
        ),
        new Charm(
            "黒子の金属矢",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(7000, 20000, 7000, 16000),
            new(2023, 8, 31)
        ),
        new Charm(
            "食蜂のリモコン",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(7000, 8000, 17000, 18000),
            new(2023, 8, 31)
        ),
        new Charm(
            "美琴のコイン(メイドスタイル)",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(18000, 10000, 12500, 9500),
            new(2023, 8, 31)
        ),
        new Charm(
            "食蜂のリモコン(メイドスタイル)",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のSp.ATK/Sp.DEFが大ダウンする。",
            new(7000, 18000, 7000, 18000),
            new(2023, 8, 31)
        ),
        new Charm(
            "アステリオンSP.KY",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(10000, 18000, 9500, 12500),
            new(2023, 8, 20)
        ),
        new Charm(
            "ティルフィングSP.SH",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+6%。",
            new(18500, 10000, 11500, 10000),
            new(2023, 8, 20)
        ),
        new Charm(
            "ミミング",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のATK/DEFが大ダウンする。",
            new(17600, 9900, 16500, 11000),
            new(2023, 8, 17)
        ),
        new Charm(
            "グンフィエズル",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2023, 8, 17)
        ),
        new Charm(
            "グングニルカービンSP.TT(Ver2)",
            " メモリアスキル効果UP+50%",
            new(10445, 10471, 10458, 10626),
            new(2023, 8, 10)
        ),
        new Charm(
            "グングニルカービンSP.BE(Ver2)",
            " メモリアスキル効果UP+50%",
            new(10445, 10471, 10458, 10626),
            new(2023, 7, 11)
        ),
        new Charm(
            "ブルトガングGLT",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(20000, 10000, 10000, 10000),
            new(2023, 7, 3)
        ),
        new Charm(
            "マルテSP.MF",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/DEFが大アップする。",
            new(18500, 10000, 11500, 10000),
            new(2023, 6, 30)
        ),
        new Charm(
            "ブリューナクSP.MY",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のDEF/Sp.DEFが大アップし、HP回復時はHPの回復量がアップする。",
            new(8500, 8500, 16500, 16500),
            new(2023, 6, 30)
        ),
        new Charm(
            "レーヴァテイン",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のSp.ATK/Sp.DEFが大ダウンする。",
            new(9900, 17600, 11000, 16500),
            new(2023, 6, 21)
        ),
        new Charm(
            "シャルルマーニュSP.RS(Ver2)",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(9500, 19000, 9500, 12000),
            new(2023, 6, 18)
        ),
        new Charm(
            "風の大剣",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(18700, 10000, 11300, 10000),
            new(2023, 6, 9)
        ),
        new Charm(
            "樹の花輪",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(17000, 17000, 8000, 8000),
            new(2023, 6, 9)
        ),
        new Charm(
            "友奈の豪腕",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(7000, 20000, 7000, 16000),
            new(2023, 6, 9)
        ),
        new Charm(
            "園子の槍",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/DEFが大アップする。",
            new(18700, 10000, 11300, 10000),
            new(2023, 6, 3)
        ),
        new Charm(
            "グングニルカービンSP.MK",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2023, 6, 3)
        ),
        new Charm(
            "友奈の甲手",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火属性メモリアの場合、さらにメモリアスキル効果UP+7%。",
            new(20000, 7000, 16000, 7000),
            new(2023, 5, 31)
        ),
        new Charm(
            "美森の銃",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のDEF/Sp.DEFが大アップし、HP回復時はHPの回復量がアップする。",
            new(8500, 8500, 16500, 16500),
            new(2023, 5, 31)
        ),
        new Charm(
            "夏凜の刀",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のSp.ATK/Sp.DEFが大アップする。",
            new(9500, 18900, 9500, 12100),
            new(2023, 5, 31)
        ),
        new Charm(
            "夏凜の刀(ザフ)",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2023, 5, 31)
        ),
        new Charm(
            "ティルフィングSP.MM",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(10000, 18500, 10000, 11500),
            new(2023, 4, 30)
        ),
        new Charm(
            "グングニルカービンSP.KM",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2023, 4, 30)
        ),
        new Charm(
            "アステリオンマギカノンSP.KM",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(18500, 10000, 11500, 10000),
            new(2023, 4, 30)
        ),
        new Charm(
            "アルケミートレースSP.SR",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(10000, 20000, 10000, 10000),
            new(2023, 4, 30)
        ),
        new Charm(
            "シャルルマーニュSP.TT",
            " メモリアスキル効果UP+50%",
            new(9660, 9660, 11340, 11340),
            new(2023, 4, 13)
        ),
        new Charm(
            "プレシューズ",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のATK/Sp.ATKが大ダウンする。",
            new(18000, 18000, 9500, 9500),
            new(2023, 4, 13)
        ),
        new Charm(
            "ブリューナクSP.SS",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(18500, 10000, 11500, 10000),
            new(2023, 3, 31)
        ),
        new Charm(
            "グングニルカービンSP.IF",
            " メモリアスキル効果UP+50%",
            new(10445, 10471, 10458, 10626),
            new(2023, 3, 31)
        ),
        new Charm(
            "クリューサーオールSP.IF",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/水属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(10000, 18500, 10000, 11500),
            new(2023, 3, 31)
        ),
        new Charm(
            "タスラム",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のDEF/Sp.DEFが大アップする。",
            new(10175, 10175, 17325, 17325),
            new(2023, 3, 16)
        ),
        new Charm(
            "さやかの剣",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(15100, 7550, 13350, 9000),
            new(2023, 3, 3)
        ),
        new Charm(
            "杏子の槍",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(7550, 15100, 9000, 13350),
            new(2023, 3, 3)
        ),
        new Charm(
            "まどかの弓",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のSp.ATK/Sp.DEFが大アップする。",
            new(7550, 15100, 9000, 13350),
            new(2023, 2, 28)
        ),
        new Charm(
            "ほむらの拳銃",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/Sp.ATKが大アップする。",
            new(15000, 15000, 7500, 7500),
            new(2023, 2, 28)
        ),
        new Charm(
            "マミのマスケット銃",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/DEFが大アップする。",
            new(15100, 7550, 13350, 9000),
            new(2023, 2, 28)
        ),
        new Charm(
            "ゲイボルグSP.HA",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(7425, 14850, 8550, 14175),
            new(2023, 1, 31)
        ),
        new Charm(
            "ティルフィングSP.YH",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/風属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(14850, 7425, 14175, 8550),
            new(2023, 1, 31)
        ),
        new Charm(
            "エクスカリバー",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(7875, 15000, 9000, 13125),
            new(2022, 12, 25)
        ),
        new Charm(
            "ナインライブズ",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(15000, 7875, 13125, 9000),
            new(2022, 12, 25)
        ),
        new Charm(
            "マジカルルビー",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/DEFが大アップする。",
            new(15000, 7875, 13125, 9000),
            new(2022, 12, 22)
        ),
        new Charm(
            "マジカルサファイア",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のSp.ATK/Sp.DEFが大アップする。",
            new(7875, 15000, 9000, 13125),
            new(2022, 12, 22)
        ),
        new Charm(
            "干将",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方2体のATKが大アップする。",
            new(15000, 7875, 13125, 9000),
            new(2022, 12, 22)
        ),
        new Charm(
            "莫耶",
            " メモリアスキル効果UP+50%",
            new(10710, 10584, 10290, 10416),
            new(2022, 12, 22)
        ),
        new Charm(
            "グングニルカービンSP.CE",
            " メモリアスキル効果UP+50%",
            new(10445, 10471, 10458, 10626),
            new(2022, 12, 22)
        ),
        new Charm(
            "キャリバーン",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.ATKが大アップする。",
            new(17600, 17600, 9900, 9900),
            new(2022, 12, 21)
        ),
        new Charm(
            "アステリオンSP.WL",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水/風属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(14625, 7875, 13950, 8550),
            new(2022, 11, 10)
        ),
        new Charm(
            "Ⅳ号戦車H型",
            " メモリアスキル効果UP+10%。メモリア使用時、それが風/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(15000, 8100, 12900, 9000),
            new(2022, 10, 31)
        ),
        new Charm(
            "ティーガーⅠ",
            " メモリアスキル効果UP+10%。メモリア使用時、それが風/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(8100, 15000, 9000, 12900),
            new(2022, 10, 31)
        ),
        new Charm(
            "チャーチル",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のSp.ATK/Sp.DEFが大アップする。",
            new(8100, 15000, 9000, 12900),
            new(2022, 10, 31)
        ),
        new Charm(
            "P40型重戦車",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/DEFが大アップする。",
            new(15000, 8100, 12900, 9000),
            new(2022, 10, 31)
        ),
        new Charm(
            "アロンダイト",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のDEF/Sp.DEFが大ダウンする。",
            new(10450, 10450, 17050, 17050),
            new(2022, 10, 27)
        ),
        new Charm(
            "ジャック・モンドラゴン",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+4%。",
            new(14400, 14400, 8100, 8100),
            new(2022, 10, 15)
        ),
        new Charm(
            "ガングニール(ラストイグニッション)",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(14625, 7875, 13950, 8550),
            new(2022, 10, 7)
        ),
        new Charm(
            "ブルンツヴィークSP.IS",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(7920, 14580, 8100, 14400),
            new(2022, 8, 31)
        ),
        new Charm(
            "クリューサーオールSP.TS",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(14580, 7920, 14400, 8100),
            new(2022, 8, 31)
        ),
        new Charm(
            "コルブランド",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATK/Sp.DEFが大アップする。",
            new(9900, 17600, 11000, 16500),
            new(2022, 8, 10)
        ),
        new Charm(
            "タンキエム・サマー",
            "メモリアスキル効果UP+10%。メモリア使用時、それが光/闇属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(8100, 14400, 8460, 14040),
            new(2022, 7, 20)
        ),
        new Charm(
            "アルケミートレース",
            "メモリアスキル効果UP+10%。メモリア使用時、それが光/闇属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(14625, 7875, 14625, 7875),
            new(2022, 6, 30)
        ),
        new Charm(
            "デュランダル・サマー",
            "メモリアスキル効果UP+10%。メモリア使用時、それが風/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(13725, 8100, 13275, 9900),
            new(2022, 6, 17)
        ),
        new Charm(
            "マルミアドワーズ",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/DEFが大アップする。",
            new(17600, 9900, 16500, 11000),
            new(2022, 6, 9)
        ),
        new Charm(
            "グングニルSP.HM",
            "メモリアスキル効果UP+10%。メモリア使用時、それが光/闇属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(13950, 13950, 8550, 8550),
            new(2022, 5, 31)
        ),
        new Charm(
            "エゼルリング",
            "メモリアスキル効果UP+10%。メモリア使用時、それが風/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(9450, 9450, 13050, 13050),
            new(2022, 4, 30)
        ),
        new Charm(
            "シュガールSP.AS",
            "メモリアスキル効果UP+10%。メモリア使用時、それが水/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(13500, 8550, 13500, 9450),
            new(2022, 4, 30)
        ),
        new Charm(
            "ブルトガングSP.MK",
            "メモリアスキル効果UP+10%。メモリア使用時、それが火/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(8550, 13500, 9450, 13500),
            new(2022, 4, 30)
        ),
        new Charm(
            "ティルフィングPrtSP",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2022, 4, 15)
        ),
        new Charm(
            "シャルルマーニュSP.RS",
            " メモリアスキル効果UP+10%。メモリア使用時、それが風/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(13950, 13950, 8550, 8550),
            new(2022, 4, 15)
        ),
        new Charm(
            "フラガラッハ",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.ATKが大アップする。",
            new(16500, 16500, 11000, 11000),
            new(2022, 4, 4)
        ),
        new Charm(
            "サンダルフォン",
            " メモリアスキル効果UP+10%。メモリア使用時、それが水/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(8550, 13950, 9450, 13050),
            new(2022, 3, 31)
        ),
        new Charm(
            "カマエル",
            " メモリアスキル効果UP+10%。メモリア使用時、それが風/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(8450, 15000, 8550, 13000),
            new(2022, 3, 31)
        ),
        new Charm(
            "ザフキエル",
            " メモリアスキル効果UP+10%。メモリア使用時、それが火/光/闇属性メモリアの場合、さらにメモリアスキル効果UP+3%。",
            new(13950, 8550, 13050, 9450),
            new(2022, 3, 31)
        ),
        new Charm(
            "ザフキエル(ザフ)",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2022, 3, 31)
        ),
        new Charm(
            "デュランダルSP.TM",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のDEF/Sp.DEFが大アップし、HP回復時はHPの回復量がアップする。",
            new(9787, 9788, 11745, 12180),
            new(2022, 2, 19)
        ),
        new Charm(
            "グングニルSP.KY",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/DEFが大アップする。",
            new(13050, 8700, 12180, 9570),
            new(2022, 2, 19)
        ),
        new Charm(
            "クリューサーオールSP.FA",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATK/Sp.DEFが大アップする。",
            new(8700, 13050, 9570, 12180),
            new(2022, 2, 19)
        ),
        new Charm(
            "ティルフィングSP.MT",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.ATKが大アップする。",
            new(14400, 8550, 13500, 8550),
            new(2022, 2, 9)
        ),
        new Charm(
            "フルンティング",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATK/DEFが大アップする。",
            new(8650, 13100, 9490, 12260),
            new(2022, 1, 20)
        ),
        new Charm(
            "ネイリング",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.DEFが大アップする。",
            new(13100, 8650, 12260, 9490),
            new(2022, 1, 20)
        ),
        new Charm(
            "アステリオンSP.KR",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のATK/Sp.DEFが大ダウンする。",
            new(11882, 11840, 9910, 9868),
            new(2022, 1, 20)
        ),
        new Charm(
            "フィエルボワ",
            " メモリアスキル効果UP+50%",
            new(10446, 10470, 10458, 10626),
            new(2022, 1, 20)
        ),
        new Charm(
            "シャルルマーニュ改.FS",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛2体のSp.ATKが大アップする。",
            new(8566, 12764, 9994, 12176),
            new(2022, 1, 20)
        ),
        new Charm(
            "クリューサーオールSP.TT",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のATK/Sp.ATKが大ダウンする。",
            new(13500, 9900, 12600, 9000),
            new(2022, 1, 6)
        ),
        new Charm(
            "グングニルカービンSP.TT",
            " メモリアスキル効果UP+50%",
            new(10445, 10471, 10458, 10626),
            new(2022, 1, 6)
        ),
        new Charm(
            "ガングニール",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のSp.ATK/DEFが大アップする。",
            new(9240, 12264, 8820, 11676),
            new(2021, 12, 26)
        ),
        new Charm(
            "神獣鏡",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/Sp.ATKが大アップする。",
            new(11424, 11298, 9702, 9576),
            new(2021, 12, 26)
        ),
        new Charm(
            "イチイバル",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/Sp.DEFが大アップする。",
            new(12180, 8862, 11760, 9198),
            new(2021, 12, 26)
        ),
        new Charm(
            "ラピス・フィロソフィカス",
            " メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方1体のATK/Sp.DEFが大アップする。",
            new(12516, 9408, 11676, 8400),
            new(2021, 12, 26)
        ),
        new Charm(
            "ブリューナク・スノウ",
            "メモリアスキル効果UP+10%。メモリア使用時、それが風属性メモリアの場合、さらにメモリアスキル効果UP+5%。",
            new(8400, 12222, 9660, 11718),
            new(2021, 12, 13)
        ),
        new Charm(
            "ブルンツヴィークSP.WA",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATK/DEFが大アップする。",
            new(9450, 12825, 12600, 10125),
            new(2021, 12, 9)
        ),
        new Charm(
            "グングニルSP.HY",
            "メモリアスキル効果UP+10%",
            new(9955, 9730, 11980, 11753),
            new(2021, 11, 30)
        ),
        new Charm(
            "マルテSP.KM",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で敵1体のDEF/Sp.DEFが大ダウンする。",
            new(10355, 10130, 12380, 12153),
            new(2021, 11, 10)
        ),
        new Charm(
            "グングニルSP.EK",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATK/Sp.DEFが大アップする。",
            new(10418, 12014, 10395, 12173),
            new(2021, 10, 7)
        ),
        new Charm(
            "ジャック・オー・マルテ",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATKが大アップする。",
            new(12600, 9030, 10920, 9450),
            new(2021, 9, 30)
        ),
        new Charm(
            "ブリューナクSP.TI",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.DEFが大アップする。",
            new(12205, 10467, 10254, 12074),
            new(2021, 9, 14)
        ),
        new Charm(
            "RH・エストレア",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATKが大アップ、DEFがアップする。",
            new(8520, 11934, 8940, 12606),
            new(2021, 8, 31)
        ),
        new Charm(
            "BD・ホーネット",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATKが大アップ、DEFがアップする。",
            new(9150, 12564, 8310, 11976),
            new(2021, 8, 31)
        ),
        new Charm(
            "シュベルトクロイツ",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATKが大アップ、Sp.DEFがアップする。",
            new(12501, 8814, 11619, 9066),
            new(2021, 8, 31)
        ),
        new Charm(
            "アステリオンSP.EA",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/DEFが大アップする。",
            new(12218, 10480, 11925, 10377),
            new(2021, 8, 19)
        ),
        new Charm(
            "グングニルカービンSP.BE",
            " メモリアスキル効果UP+50%",
            new(10445, 10471, 10458, 10626),
            new(2021, 7, 20)
        ),
        new Charm(
            "アステリオンSP.BE",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のDEF/Sp.DEFが大アップする。",
            new(10440, 10395, 12375, 11790),
            new(2021, 7, 20)
        ),
        new Charm(
            "グングニル・サマー",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のSp.ATKが大アップする。",
            new(9240, 12180, 8820, 11760),
            new(2021, 6, 18)
        ),
        new Charm(
            "アステリオンSP.MM",
            "メモリアスキル効果UP+10%",
            new(10703, 10082, 10243, 9664),
            new(2021, 5, 31)
        ),
        new Charm(
            "グラム",
            "メモリアスキル効果UP+10%。メモリア使用時、10%の確率で味方前衛1体のATK/Sp.ATKが大アップする。",
            new(11191, 11218, 11205, 11385),
            new(2021, 5, 28)
        ),
        new Charm(
            "アステリオンマギカノン",
            "メモリアスキル効果UP+10%",
            new(12180, 9240, 11760, 8820),
            new(2021, 4, 30)
        ),
        new Charm(
            "グングニル",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "ブリューナク",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "ジョワユーズ",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "グングニルSP.FF",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "ティルフィング",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "タンキエム",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "媽祖聖札(マソレリック)",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "アステリオン",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "ニョルニール",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "ブルトガング",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "モンドラゴン",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "ブルンツヴィーク",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "クリューサーオール",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "ゲイボルグ",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "クラウ・ソラス",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "リサナウト",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "シュガール",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "マルテ",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
        new Charm(
            "デュランダル",
            "メモリアスキル効果UP+10%",
            new(10403, 10382, 9943, 9964),
            new(2021, 1, 20)
        ),
    ];
}