docker-compose up
http://localhost:7000/api/values

You will see:

[{"id":1,"name":"julie"},{"id":2,"name":"giantpuppy"}]

-I have installed nc command in sql server docker 
container.

RUN apt-get update && apt-get install -y \
    netcat

-I have improved sql server docker container with this command:

until nc -z -v -w30 localhost 1433
do
  echo "Waiting for database connection..."
  # wait for 5 seconds before check again
  sleep 5
done

In this way the sql script works always and you don't
have to wait "n seconds" to execute sql script.

-Utilities

-Test if a file has linux format (LF ENDINGS):
$ file -k prueba.txt
prueba.txt: ASCII text\012- data

$ file -k SqlCmdScript.sql
SqlCmdScript.sql: ASCII text, with CRLF line terminators\012- data


-Convert a file to a linux format, with dos2unix utility
choco install dos2unix

jordi@DESKTOP-P1CA12J MINGW64 ~/source/repos/CapgeminiWebApi (master)
$ dos2unix SqlCmdStartup.sh
dos2unix: converting file SqlCmdStartup.sh to Unix format...

jordi@DESKTOP-P1CA12J MINGW64 ~/source/repos/CapgeminiWebApi (master)
$ dos2unix entrypoint.sh
dos2unix: converting file entrypoint.sh to Unix format...

