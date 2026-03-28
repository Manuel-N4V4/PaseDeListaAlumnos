#!/bin/bash

MYSQL_CONTAINER="mysql_pase_lista"
DB_NAME="pase_de_lista"
DB_ROOT_PASS="1234"
LOCAL_BACKUP_DIR="./backups"

TIMESTAMP=$(date +"%Y%m%d_%H%M%S")
BACKUP_FILE="backup_${DB_NAME}_${TIMESTAMP}.sql"

echo "== Respaldo de Base de Datos =="

mkdir -p "$LOCAL_BACKUP_DIR"

docker exec "$MYSQL_CONTAINER" mysqldump -u root -p"$DB_ROOT_PASS" "$DB_NAME" > "$LOCAL_BACKUP_DIR/$BACKUP_FILE"

if [ $? -ne 0 ]; then
    echo "ERROR: Fallo el respaldo"
    rm -f "$LOCAL_BACKUP_DIR/$BACKUP_FILE"
    exit 1
fi

echo "Respaldo creado en: $LOCAL_BACKUP_DIR/$BACKUP_FILE"