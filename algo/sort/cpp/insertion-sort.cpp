#include <iostream>
using namespace std ;

void InsertionSort(int * nums , int lenght );

int main(){
}



void InsertionSort(int * nums , int lenght ){
    for(int i = 1 ; i < lenght ; ++i ){
        int current = nums[i];
        int j = i - 1 ;

        while( j >= 0 && nums[j] > current ){
            nums[j + 1 ] = nums[j];
            --j ;
        }

        nums[j + 1 ] = current ;
    }
}