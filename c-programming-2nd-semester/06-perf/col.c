// col.c
#include <stdio.h>
#define N 4096
double a[N][N];
int main() {
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
            a[i][j] = (double)(i + j);
    double sum = 0;
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
            sum += a[j][i];
    printf("Sum: %f\n", sum);
    return 0;
}
