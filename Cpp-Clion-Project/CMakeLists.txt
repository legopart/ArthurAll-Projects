cmake_minimum_required(VERSION 3.23)
project(Cpp_Clion_Project)

set(CMAKE_CXX_STANDARD 20)

include_directories(.)

add_executable(NonLinear-HeapTree DataStructureNonLinear/HeapTree/main.cpp)

add_executable(NonLinear-AVLTree DataStructureNonLinear/AVLTree/main.cpp)

add_executable(NonLinear-BinartTree DataStructureNonLinear/BinaryTree/main.cpp)

add_executable(Cpp_Clion_Project main.cpp DataStructureNonLinear/BinaryTree/main.cpp DataStructureNonLinear/BinaryTree/Tree.cpp DataStructureNonLinear/AVLTree/main.cpp DataStructureNonLinear/AVLTree/Tree.cpp DataStructureNonLinear/HeapTree/main.cpp DataStructureNonLinear/HeapTree/Heap.cpp DataStructureNonLinear/HeapTree/PriorityQueue.cpp DataStructureNonLinear/HeapTree/HeapVector.cpp)

add_executable(Linear-ArrayList DataStructure/ArrayList/main.cpp)

add_executable(Linear-LinkedList DataStructure/LinkedList/main.cpp)

add_executable(Linear-Stack DataStructure/Stack/main.cpp)

add_executable(Linear-Queue DataStructure/Queue/main.cpp)

add_executable(Linear-Hashtable DataStructure/Hashtable/main.cpp)


