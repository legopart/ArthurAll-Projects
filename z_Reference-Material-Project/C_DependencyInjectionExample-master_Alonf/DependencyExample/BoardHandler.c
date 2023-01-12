
#define BOARD_HANDLER_PRIVATE
#include "BoardHandler.h"
#include <assert.h>
#include <stdlib.h>


board_t board_handler_initiate(const board_handler_init_t* init)
{
    assert(init);
    assert(init->print_func);
    assert(init->operation_func);
    assert(init->new_line_func);
    assert(init->width > 0);
    assert(init->height > 0);

    board_info_t* p_board_info = malloc(sizeof(board_info_t));
    if (p_board_info == NULL)
    {
        return NULL;
    }
    
    p_board_info->init = *init;
    p_board_info->operation_count = 0;
    
    return p_board_info;
}

void board_handler_calculate(board_t board)
{
    assert(board);
    board_info_t* board_info = (board_info_t*)board;
    for (int y = 1; y <= board_info->init.height; y++)
    {
        for (int x = 1; x <= board_info->init.width; x++)
        {
            board_info->init.print_func(board_info->init.operation_func(y, x));
            board_info->operation_count++;
        }
        board_info->init.new_line_func();
    }
}

void board_handler_destroy(board_t board)
{
    free(board);
}

int board_handler_get_number_of_operations(board_t board)
{
    return ((board_info_t*)board)->operation_count;
}
