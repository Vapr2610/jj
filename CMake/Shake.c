#include"head.h"

// Функция сортировки методом шейкерной сортировки (шейкерной сортировки)
void cocktail_sort(int arr[], int n) {
    int left = 0, right = n - 1, swapped = 0;

    while (left < right && !swapped) {
        swapped = 1;
        for (int i = left; i < right; i++) {
            if (arr[i] > arr[i + 1]) {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = 0;
            }
        }
        right--;

        if (!swapped) {
            swapped = 1;
            for (int i = right; i > left; i--) {
                if (arr[i] < arr[i - 1]) {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                    swapped = 0;
                }
            }
            left++;
        }
    }
}