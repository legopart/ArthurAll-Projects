# CMakeList.txt : CMake project for CMakeProjectDemo2, include source and define
# project specific logic here.
#
cmake_minimum_required (VERSION 3.8)

project ("CMakeProjectDemo2")

# Add source to this project's executable.
add_executable (CMakeProjectDemo2 "CMakeProjectDemo2.cpp" "CMakeProjectDemo2.h")

# TODO: Add tests and install targets if needed.
    find_package(cpr CONFIG REQUIRED)
    target_link_libraries(CMakeProjectDemo2 PRIVATE cpr::cpr)