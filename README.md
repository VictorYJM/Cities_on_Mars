# Cities on Mars

![Screenshot 2024-09-22 111609](https://github.com/user-attachments/assets/20dd5639-985e-4ca1-ab74-de51dabc6afa)

## Description

**Paths on Mars** is a desktop application written in C# that allows users to manage cities and their paths on a map, using various hash table techniques to store city data. The application focuses on visualizing paths and distances between cities using a graph.

## Features

- **City Management**:
  - Reading city data from text files with options related to data storage methods.
  - Insertion, removal, and search of cities along with their coordinates.
  - Listing cities on an interactive map.

- **Path Management**:
  - Creating connections between cities with specified distances.
  - Deleting paths between cities.
  - Modifying distances of existing paths.
  - Searching for all possible paths between two cities and calculating the shortest route.

- **Visualization**:
  - Drawing cities on a map with their respective connections.

## Tests

### Reading the City File
<img src="https://github.com/user-attachments/assets/5c994d2b-c67a-4898-92d9-fa2899354233" alt="City File Reading Test">
<img src="https://github.com/user-attachments/assets/c84ac8e3-4014-4635-82b9-fa4b97b5690f" alt="City File Reading Result">

### Adding a City
<img src="https://github.com/user-attachments/assets/c1bdc0f6-bc78-4b8e-bd08-1c6b88939741" alt="Preparing to Add City">
<img src="https://github.com/user-attachments/assets/797bfdb8-d4ea-40a8-85c5-2e04a8661072" alt="City Added">

### Removing a City
<img src="https://github.com/user-attachments/assets/bd0c105a-da3f-426f-9076-dfd4a9568d7a" alt="Preparing to Remove City">
<img src="https://github.com/user-attachments/assets/0420cbdb-36b1-47f2-9127-de6b3accef02" alt="City Removed">

### Searching for a City
<img src="https://github.com/user-attachments/assets/008dabeb-f570-4401-9f40-8d5c8cb1a7df" alt="Preparing to Search for City">
<img src="https://github.com/user-attachments/assets/0bafb991-bb2e-411d-ba14-c3a579a634a4" alt="City Found">

### Listing Cities
<img src="https://github.com/user-attachments/assets/d6eb77c1-3f38-452e-9006-b86bf2abadb9" alt="Listed Cities">

### Reading the Paths Between Cities File
<img src="https://github.com/user-attachments/assets/4042ce4d-7252-4990-8295-5c0c6c5421ef" alt="City File Reading Test">
<img src="https://github.com/user-attachments/assets/3ecf4cd8-2324-4988-94f2-6c3a9f304c7c" alt="Paths Between Cities File Reading Test">
<img src="https://github.com/user-attachments/assets/1545517f-c69f-489e-bb33-d57fb751cf54" alt="Result of Reading Files">

### Adding a Path Between Cities
<img src="https://github.com/user-attachments/assets/4d31c81c-605e-42fb-a2d3-73831e1570f6" alt="Preparing to Add Path Between Cities">
<img src="https://github.com/user-attachments/assets/b5eedc61-8afc-4a84-868d-cab9d9b0add6" alt="Path Added">

### Removing a Path Between Cities
<img src="https://github.com/user-attachments/assets/f6b9ca93-4f4e-46c6-9826-255383eca187" alt="Preparing to Remove Path Between Cities">
<img src="https://github.com/user-attachments/assets/4ecfaa6b-4f91-4cbc-b472-52b754744529" alt="Path Removed">

### Modifying a Path Between Cities
<img src="https://github.com/user-attachments/assets/d5d545f2-98da-4dc0-b02f-c302347a8a26" alt="Preparing to Modify Path Between Cities">
<img src="https://github.com/user-attachments/assets/7c8c2f66-5584-4fc4-8140-c9777fb93509" alt="Path Modified">

### Searching for All Paths Between Two Cities
<img src="https://github.com/user-attachments/assets/d0e06e2b-44ff-4285-86ae-825c9925f4bc" alt="Preparing to Search for All Paths">
<img src="https://github.com/user-attachments/assets/1caecfb8-1e31-44e6-a517-21d1af547dc5" alt="Displaying Path 1">
<img src="https://github.com/user-attachments/assets/1bc3e669-03e8-4c00-826a-adcc980c7e6e" alt="Displaying Path 2">
<img src="https://github.com/user-attachments/assets/ce2e478b-8377-4bd7-9b26-53ee3f36f8f4" alt="Displaying Path 3">

### Saving Data Changes
<img src="https://github.com/user-attachments/assets/75379d2d-145b-4a42-8279-44b7bcb3938e" alt="Preparing to Save Data and Close Program">
<img src="https://github.com/user-attachments/assets/34cb73cc-f9a3-465e-acf9-d1f5bf97e7cb" alt="Saving Data to City File">
<img src="https://github.com/user-attachments/assets/67d11611-35a2-4281-9003-f0c688b9193b" alt="Saving Data to Paths File">

## Technologies Used

- C#
- Windows Forms
- Hash Algorithms
- Graph Algorithms
- Stack Algorithms
- Backtracking
