@echo off
set /p COMMENT="コメントを入力してください: "
git add .
git commit -m %COMMENT%
git push