@echo off
set /p COMMENT="�R�����g����͂��Ă�������: "
git add .
git commit -m %COMMENT%
git push