cmake_minimum_required(VERSION 3.23)
project(Cpp_Clion_Project)

set(CMAKE_CXX_STANDARD 20)

include_directories(.)


add_executable(Algorithms-Sorting DataStructureAlgorithms/Sorting/main.cpp)

add_executable(NonLinear-GraphUndirected DataStructureNonLinear/GraphUndirected/main.cpp)

add_executable(NonLinear-Graph DataStructureNonLinear/Graph/main.cpp)

add_executable(NonLinear-TrieTree DataStructureNonLinear/TrieTree/main.cpp)

add_executable(NonLinear-HeapTree DataStructureNonLinear/HeapTree/main.cpp)

add_executable(NonLinear-AVLTree DataStructureNonLinear/AVLTree/main.cpp)

add_executable(NonLinear-BinartTree DataStructureNonLinear/BinaryTree/main.cpp)

add_executable(Cpp_Clion_Project main.cpp DataStructureAlgorithms/Sorting/main.cpp DataStructureAlgorithms/Sorting/bubbleSort.cpp DataStructureAlgorithms/Sorting/selectionSort.cpp DataStructureAlgorithms/Sorting/insertionSort.cpp DataStructureAlgorithms/Sorting/mergeSort.cpp DataStructureAlgorithms/Sorting/quickSort.cpp)

add_executable(Linear-ArrayList DataStructure/ArrayList/main.cpp)

add_executable(Linear-LinkedList DataStructure/LinkedList/main.cpp)

add_executable(Linear-Stack DataStructure/Stack/main.cpp)

add_executable(Linear-Queue DataStructure/Queue/main.cpp)

add_executable(Linear-Hashtable DataStructure/Hashtable/main.cpp)


