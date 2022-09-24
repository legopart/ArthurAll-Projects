cmake_minimum_required(VERSION 3.23)
project(C_Clion_Project C)

set(CMAKE_C_STANDARD 23)

add_executable(_exerciseTest _exerciseTest.c)

add_executable(_exercise1 _exercise1.c)

add_executable(string string.c)

add_executable(scope scope.c)

add_executable(static static.c)

add_executable(pointers pointers.c)

add_executable(const.c const.c)

add_executable(malloc.c malloc.c)

add_executable(macros macros.c)

add_executable(struct1 struct1.c)

add_executable(struct2 struct2.c)

add_executable(C_Clion_Project main.c)
