#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Размер матрицы Плейфера
#define MATRIX_SIZE 5
extern char matrix[MATRIX_SIZE][MATRIX_SIZE];


void createKeyMatrix(char *keyString);
void findIndices(char c1, char c2, int *i1, int *j1, int *i2, int *j2);
char* PlayKey(char *plaintext1, char *key);
char* DePlayKey(char *plaintext1, char *key);