#!/bin/bash


if [ -d "0-new_project" ]; then
    echo "Folder '0-new_project' already exists."
    exit 1
fi


dotnet new console -o 0-new_project


if [ $? -eq 0 ]; then
    echo "The template \"Console Application\" was created successfully."
else
    echo "Failed to create the project."
    exit 1
fi
