#include"head.h"

// Функция для заполнения массива с клавиатуры
void fill_keyboard(int arr[], int n) {
    printf("Введите %d элементов массива:\n", n);
    for (int i = 0; i < n; i++) {
        scanf("%d", &arr[i]);
    }
}