// DependencyExample.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "BoardHandler.h"
#include "BoardPainter.h"

double multiply(double a, double b)
{
    return a * b;
}

double addition(double a, double b)
{
    return a + b;
}

int main()
{
    board_handler_init_t board_init;
    board_init.height = 10;
    board_init.width = 5;
    board_init.operation_func = addition;
    board_init.print_func = board_painter_print;
    board_init.new_line_func = board_painter_print_newline;
    
    board_t addition_board = 
        board_handler_initiate(&board_init);
    
    
    board_init.operation_func = multiply;
    board_init.width = 10;
    board_t multiplication_board = 
        board_handler_initiate(&board_init);
    
    board_handler_calculate(addition_board);
    board_painter_print(
        board_handler_get_number_of_operations(addition_board));
    board_handler_destroy(addition_board);
    
    board_painter_print_newline();
    board_handler_calculate(multiplication_board);
    board_painter_print(
        board_handler_get_number_of_operations(multiplication_board));
    board_handler_destroy(multiplication_board);
    
}
