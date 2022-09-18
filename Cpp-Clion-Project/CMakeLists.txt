cmake_minimum_required(VERSION 3.23)
project(Cpp_Clion_Project)

set(CMAKE_CXX_STANDARD 20)

include_directories(.)




add_executable(ArrayList DataStructure/ArrayList/main.cpp DataStructure/Hashtable/main.cpp DataStructure/Hashtable/HashtableChaining.cpp)

add_executable(LinkedList DataStructure/LinkedList/main.cpp)

add_executable(Stack DataStructure/Stack/main.cpp)

add_executable(Queue DataStructure/Queue/main.cpp)

add_executable(Hashtable DataStructure/Hashtable/main.cpp)

add_executable(Cpp_Clion_Project main.cpp)
