#pragma once

typedef void print_t(double value);
typedef double operation_t(double param1, double param2);
typedef void new_line_func_t();

typedef struct
{
    print_t* print_func;
    int width;
    int height;
    operation_t *operation_func;
    new_line_func_t* new_line_func;

} board_handler_init_t;


typedef void* board_t;

board_t board_handler_initiate(const board_handler_init_t* init);

void board_handler_calculate(board_t board);

void board_handler_destroy(board_t board);

int board_handler_get_number_of_operations(board_t board);

#ifdef BOARD_HANDLER_PRIVATE
typedef struct
{
    board_handler_init_t init;
    int operation_count;
} board_info_t;

#endif //BOARD_HANDLER_PRIVATE
