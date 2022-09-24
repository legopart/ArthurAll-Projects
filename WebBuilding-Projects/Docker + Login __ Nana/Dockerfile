FROM node:13-alpine
#docker(container)
ENV MONGO_DB_USERNAME=admin \
    MONGO_DB_PWD=admin
#docker(container)
RUN mkdir -p /home/app
#local(host)
COPY ./app /home/app
#local(host) dir
WORKDIR /home/app
#docker(container) inside WORKDIR address
RUN npm install
#local(host) Command inside WORKDIR address
CMD ["node", "server.js"]

