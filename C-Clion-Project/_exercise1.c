 #include <stdio.h>


//	פונצקיית חזקה X^a
int powX(int x, int a){
	int result=1;
    for(int i=1;i<=a;i++) result *= x;
    return result;
}

//	השוואת פויינטרים
int pointerEqual(int *a, int *b){
    return *a==*b;
}

//	היפוך של מערך
void arrSwop(int arr[], int arrLength){
    for (int i=0; i<=((arrLength-1)/2); i++){
        int tmp=arr[i];
        arr[i]=arr[arrLength-1-i];
        arr[arrLength-1-i]=tmp;
    }
}

//	האיבר הכי גבוה במערך
// במידה ויש במערך לפחות 2 איברים!
int biggest(int arr[], int arrLength){
    int b=arr[0];   //biggest
    for (int i=1;i<arrLength;i++)
        if (b<arr[i]) b=arr[i];
    return b;
}

// חילוף פויינטרים
void swopPointer(int *x, int *y){
    int tmp=*x;
    *x=*y;
    *y=tmp;
}


//	האיבר ה3 הגבוה ביותר
int biggest3(int arr[], int arrLength){
    int minInt= -powX(2, (sizeof(int)*8-1) )+1; //-2147483647
    int b1, b2, b3;
    b1=b2=b3=minInt;
    for (int i=0; i< arrLength; i++){
        //if(arr[i]<b3) continue;
        if(arr[i]<=b2 && arr[i]>b3) b3=arr[i];
        else if(arr[i]<=b1 && arr[i]>b2) {b3=b2; b2=arr[i];}
        else if(arr[i]>=b1) {b3=b2; b2=b1; b1=arr[i];}
        }
    return b3;
}

//	מספרים ראשוניים עד n
// האם המספר הוא ראשוני
int isFirst(int x){ //x>2
    for(int i=2; i<x; i++)
        if(x%i==0) return 0;
    return 1;
}

//	מספרים ראשוניים עד n
int firstNumberCount(int n){
    if(n==0||n==1)return 0;
    int count=0;
    for(int i=2; i<=n; i++)
        if(isFirst(i)) count ++;
    return count;
}

//  הופך מחרוזת
//	מונה כמות תווים במחרוזת
//ממיר מצביע למחרוזת
void pointerStringToArray(char *str, char emptyarr[]){
    for (int i=0;str[i];i++){   //str[i] != NULL
        emptyarr[i]=str[i];
    }
}

int stringLength(char str[]){
    int count=0;
    for(int i=0; str[i]; i++) count++;
    return count;
}

void swopChar(char *x, char *y){
    char tmp=*x;
    *x=*y;
    *y=*x;
}

void stringSwop(char str[]){
    int length=stringLength(str);
    for (int i=0; i<=((length-1)/2); i++){
        char tmp=str[i];
        str[i]=str[length-1-i];
        str[length-1-i]=tmp;
    }
}

//	פונקציית החלפת פויינטרים של משתנים
void swop(int *x, int *y){
    int tmp=*x;
    *x=*y;
    *y=tmp;
}

//	הזזה לשמאל
//	הזזה לשמאל 3 פעמים
void turnLeft(int arr[], int arrLength){
    int repaired=arr[arrLength-1];  //last
    arr[arrLength-1]=arr[0];    //Last=First

    for(int i=(arrLength-2); i>=0; i--){
        int tmp=arr[i];
        arr[i]=repaired;
        repaired=tmp;
        }
}

void turnLeft3(int arr[], int arrLength){
        for(int i=1;i<=3; i++)
            turnLeft(arr, arrLength);
}

//	הסרת איבר -לחזור
void deleteArr(int arr[], int arrLength, int deletePlace){\
    
    for (int i=deletePlace; i<(arrLength-1); i++)
        arr[i]=arr[i+1];
    arr[arrLength-1]=-1;
}

//	להשוות בין 2 מחרוזות
int charCompare(char *str1, char *str2){
    int i;
    for(i=0; str1[i]&&str2[i]; i++){
            if(str1[i]!=str2[i]) return 0;
    } 
    if(str1[i]||str2[i]) return 0;
    return 1;
}

//	מיזוג 2 מערכים
void mergeArray(int merge[], int arr1[], int length1, int arr2[], int length2){
    for(int i=0; i<length1; i++)
        merge[i]=arr1[i];
    for(int i=0; i<length2; i++)
        merge[length1+i]=arr2[i]; // continue merge array after [length1-1]
}

//	מיזוג 2 מערכים עם מיון
    // 2 המערכים ממויינים
void mergeArraySort(int merge[], int arr1[], int length1, int arr2[], int length2){
    int i, j, m; //array1, array2, merged array counters
    i=j=m=0;
    while (i<length1){
        if(arr1[i]==arr2[j]){
            merge[m++] = arr2[j++];
            merge[m++] = arr1[i++];
        }else if (arr1[i]<arr2[j]){
            merge[m++] = arr1[i++];
        }else{
            while(arr1[i]>arr2[j])
                merge[m++] = arr2[j++];
            merge[m++] = arr1[i++];
        }
    }
    //the remain arr2 elements move to merge array
    while(j<length2)
        merge[m++]=arr2[j++];
}

//	מיון מערך
void bubleSortArray(int arr[], int arrLength){
    for(int i=0; i<arrLength; i++ )
        for(int j=i+1; j<arrLength; j++ )
            if(arr[i]>arr[j]){//swop values inside array for buble sort
                int tmp=arr[i];
                arr[i]=arr[j];
                arr[j]=tmp;
            }
}


// הדפס מערך
void printArr(int arr[], int arrLength){
        for(int i=0; i<arrLength; i++){
            printf("%i ", arr[i]);
        }
}



int main(){
return(0);}