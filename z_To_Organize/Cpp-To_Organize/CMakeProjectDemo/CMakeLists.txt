# CMakeList.txt : Top-level CMake project file, do global configuration
# and include sub-projects here.
#
cmake_minimum_required (VERSION 3.8)

project ("CMakeProjectDemo")

# Include sub-projects.
add_subdirectory ("CMakeProjectDemo")

# this is heuristically generated, and may not be correct
find_package(cpr CONFIG REQUIRED)
target_link_libraries(CMakeProjectDemo PRIVATE cpr::cpr)
