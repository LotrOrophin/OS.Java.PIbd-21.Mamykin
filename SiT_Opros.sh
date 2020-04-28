#!/bin/bash
git clone https://gitlab.com/romanov73/example-jpa.git
cd example-jpa
./gradlew build
dnf update
dnf install postgresql
docker build -t sit -f dockerfile .
systemctl stop postgresql
docker run -it --name=containersit sit