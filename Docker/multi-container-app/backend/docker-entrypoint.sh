#!/bin/sh

echo "Waiting for MongoDB to start..."
./wait-for database_mongo:27017 

echo "Migrating the databse..."
npm run db:up 

echo "Starting the server..."
npm start 