#!/bin/bash

PROJECT_NAME="0-new_project"

if [ -d "$PROJECT_NAME"]; then
  echo "Directory '$PROJECT_NAME' already exists. Exiting."
  exit 1
fi

mkdir "$PROJECT_NAME"
cd "$PROJECT_NAME"

echo "Initializing a new C# project in '$PROJECT_NAME'..."
dotnet new console

echo "C# project has been created succesfully in '$PROJECT_NAME'."
