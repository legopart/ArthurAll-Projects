#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>
#include <pthread.h>

void* routine(){ //function
    printf("Test from thread\n");
    sleep(3);
    printf("Ending thread\n");
}


int main(int argc, char *argv[])
{
    printf("multi threading\n");
    printf("parallel\n\n");

    //pthread_t t1, t2;
    pthread_t t1;
    pthread_t t2;
    int thread1body = pthread_create(&t1, NULL, &routine, NULL);
    int thread2body = pthread_create(&t2, NULL, &routine, NULL);
        // always check errors!
        if(thread1body != 0) return 1;
        if(thread2body != 0) return 1;
    int thread1join = pthread_join(t1, NULL);
    int thread2join = pthread_join(t2, NULL);
        if(thread1join != 0) return 1;
        if(thread2join != 0) return 1;
    return 0;
}