cmake_minimum_required(VERSION 3.23)
project(Cpp_Clion_Project)

set(CMAKE_CXX_STANDARD 20)

include_directories(.)


add_executable(ArrayList DataStructure/ArrayList/main.cpp)

add_executable(Cpp_Clion_Project main.cpp)
