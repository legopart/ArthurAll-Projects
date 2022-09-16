cmake_minimum_required(VERSION 3.23)
project(CLionProjects)

set(CMAKE_CXX_STANDARD 20)

include_directories(.)
add_executable(Main1 main.cpp)
add_executable(Main2 main2.cpp)
add_executable(ArrayList DataStructure/ArrayList/main.cpp DataStructure/ArrayList/Array1.cpp DataStructure/ArrayList/Array2.cpp DataStructure/ArrayList/Array2.h)


add_executable(CLionProjects main.cpp main2.cpp cmake-build-debug/cmake3/main2.h DataStructure/ArrayList/main.cpp)
