# Weather Forecast Application

## Overview

This Weather Forecast Application provides real-time weather information based on the user's current location. Built using .NET 8 and MAUI (Multi-platform App UI), this project utilizes the OpenWeatherMap API to fetch weather data.

## Features

1. Fetches weather information using the OpenWeatherMap API.
2. Automatically detects and uses the user's current location upon initial app launch.
3. Requests location permissions from the user for accurate weather updates.
4. Provides weather information not only for the current date but also for multiple times of the current and upcoming dates.

## Technologies Used

1. .NET 8
2. MAUI (Multi-platform App UI)
3. OpenWeatherMap API
4. HttpClient for API calls

## Prerequisites

To run this project, you will need:

1. Visual Studio 2022 (Version 17.4 or later) with the .NET MAUI workload installed.
2. An OpenWeatherMap API key (sign up at [OpenWeatherMap](https://openweathermap.org/)).

## Running the Application

When the app is launched for the first time, it will prompt the user for location permissions.

Upon granting permission, the app will fetch and display the current weather information for the user's location.

## Getting Started

**Installation**
1. Clone the repository:
   git clone https://github.com/Ginilytics-Org/CodeBase_MAUI.git

   cd MauiApp_Sample
3. Open the solution in Visual Studio 2022.
4. Restore the NuGet packages:
   dotnet restore
   Replace the placeholder API key in the code with your own OpenWeatherMap API key.
