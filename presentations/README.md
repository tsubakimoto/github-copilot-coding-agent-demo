# プレゼンテーション

このフォルダには GitHub Copilot の紹介プレゼンテーションが含まれています。

## ファイル

- `github-copilot-introduction.md` - GitHub Copilot の紹介プレゼンテーション（小学生・中学生向け）

## 使い方

### Marp CLI を使用してプレゼンテーションを表示

1. Marp CLI をインストール:
```bash
npm install -g @marp-team/marp-cli
```

2. HTML形式で出力:
```bash
marp github-copilot-introduction.md --html
```

3. PDF形式で出力:
```bash
marp github-copilot-introduction.md --pdf
```

4. プレゼンテーションモードで開く:
```bash
marp github-copilot-introduction.md --preview
```

## プレゼンテーション内容

- **対象者**: 小学生・中学生
- **ページ数**: 20ページ
- **言語**: 日本語
- **内容**:
  - GitHub Copilot の紹介
  - ライセンス情報
  - 使い方
  - 使用時のコツ
  - 実践的な使い方（電卓アプリの例を含む）

## 特徴

- 年齢に適した分かりやすい言葉で説明
- 絵文字を使用して親しみやすさを演出
- 実際のコード例を含む
- このリポジトリの Calculator プロジェクトを参考例として使用