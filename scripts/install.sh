#!/bin/sh

echo "Getting K pacakges"
kpm restore -s https://www.myget.org/F/aspnetvnext/
echo "Done"

echo "Use \"k run\" to build and run"