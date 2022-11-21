import sqlite3
import json
from pathlib import Path

file = Path("movies.json").read_text()
movies = json.loads(file)
print(movies)


#Run all once
# with sqlite3.connect("db.sqlite3") as conn:
#     command = "CREATE TABLE Movies(id INTEGER PRIMARY KEY, title TEXT, year INTEGER )"
#     conn.execute(command)
#     conn.commit()
#
# with sqlite3.connect("db.sqlite3") as conn:
#     command = "INSERT INTO Movies VALUES(?, ?, ?)"
#     for movie in movies:
#         conn.execute(command, tuple(movie.values()))
#     conn.commit()

with sqlite3.connect("db.sqlite3") as conn:
    command = "SELECT * FROM Movies"
    cursor = conn.execute(command)
    # for row in cursor:
    #     print(row)
    movies = cursor.fetchall()
    print(movies)

# command_create = "CREATE TABLE IF NOT EXISTS movies (id INTEGER PRIMARY KEY, title TEXT, year INTEGER);"
# conn.execute(command_create)


# CREATE TABLE "movies" (
# 	"id"	INTEGER,
# 	"title"	TEXT,
# 	"year"	INTEGER,
# 	PRIMARY KEY("id")
# );