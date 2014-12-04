#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>

#define MaxNumber 9999999
#define MaxArraysize 1000000
/*struct strdata{
  char *str;
  struct strdata *p1;
  };*/
void DataGenerate(int arraysize,char **argv);
float sortingTimeCount(int argc,char **argv);
float BubbleSort_int(int arraysize);
float BubbleSort_char(int arraysize);
float SelectionSort_int(int arraysize);
float SelectionSort_char(int arraysize);
float InsertionSort_int(int arraysize);
float InsertionSort_char(int arraysize);
float QuickSort_int(int arraysize);
float QuickSort_char(int arraysize);
int comp(const void *p,const void *q);
int compstr(const void *a,const void *b);
float MergeSort_int(int arraysize);
float MergeSort_char(int arraysize);


float startTime,endTime,totalTime;
int i,j,tempint=0,tempint2=0,count=0;
int intdata[MaxArraysize],intdata2[MaxArraysize];
char strdata[MaxArraysize][100],strdata2[MaxArraysize][100],*tempchar,buffer[100];

int main( int argc , char **argv)
{	
		float exetime[25]={0.0};
		int cv;
		DataGenerate(1000000,argv); /// temp10000

		for(cv=0;cv<25;cv++)
				exetime[cv]=sortingTimeCount(argc,argv)/CLOCKS_PER_SEC;
		
		printf("=================================== Result ==================================\n");
		printf("==Sorting    ======= 10 ===== 100 ===== 1000 ===== 10000 ===== 1000000 ======\n");
		printf("==|Bubble    |       %.2f     %.2f      %.2f       %.2f\t%.2f   (ms) \n",exetime[0],exetime[1],exetime[2],exetime[3],exetime[4]);
		printf("==|Selection |       %.2f     %.2f      %.2f       %.2f\t%.2f    (ms) \n",exetime[5],exetime[6],exetime[7],exetime[8],exetime[9]);
		printf("==|Insertion |       %.2f     %.2f      %.2f       %.2f\t%.2f    (ms) \n",exetime[10],exetime[11],exetime[12],exetime[13],exetime[14]);
		printf("==|Quick     |       %.2f     %.2f      %.2f       %.2f \t%.2f     (ms) \n",exetime[15],exetime[16],exetime[17],exetime[18],exetime[19]);
		printf("==|Merge     |       %.2f     %.2f      %.2f       %.2f \t%.2f     (ms) \n",exetime[20],exetime[21],exetime[22],exetime[23],exetime[24]);
		printf("=============================================================================\n");
}
float sortingTimeCount(int argc,char **argv)
{

		if(argv[1][0] == '-' && (argv[1][1] == 'l' || argv[1][1] == 't'))
		{
				if(argv[2][0] == 'n') 
				{
						switch(count)
						{
								case 0 : totalTime = BubbleSort_int(10); break;
								case 1 : totalTime = BubbleSort_int(100); break;
								case 2 : totalTime = BubbleSort_int(1000); break;
								case 3 : totalTime = BubbleSort_int(10000); break;
										 //case 4 : totalTime = BubbleSort_int(1000000); break;
								case 5 : totalTime = SelectionSort_int(10); break;
								case 6 : totalTime = SelectionSort_int(100); break;
								case 7 : totalTime = SelectionSort_int(1000); break;
								case 8 : totalTime = SelectionSort_int(10000); break;
										 //case 9 : totalTime = SelectionSort_int(1000000); break;
								case 10: totalTime = InsertionSort_int(10); break;
								case 11: totalTime = InsertionSort_int(100); break;
								case 12: totalTime = InsertionSort_int(1000); break;
								case 13: totalTime = InsertionSort_int(10000); break;
										 //case 14: totalTime = InsertionSort_int(1000000); break;
								case 15: totalTime = QuickSort_int(10); break;
								case 16: totalTime = QuickSort_int(100); break;
								case 17: totalTime = QuickSort_int(1000); break;
								case 18: totalTime = QuickSort_int(10000); break;
										case 19: totalTime = QuickSort_int(1000000); break;
								case 20: totalTime = MergeSort_int(10); break;
								case 21: totalTime = MergeSort_int(100); break;
								case 22: totalTime = MergeSort_int(1000); break;
								case 23: totalTime = MergeSort_int(10000); break;
										case 25: totalTime = MergeSort_int(1000000); break;
								default :  break;
						}
						count++;
				}
				else if (argv[4][0] == 's' && argc == 5 && argv[1][0] == '-' &&argv[1][1] == 'l' ) // char array
				{
						switch(count)
						{
								case 0 : totalTime = BubbleSort_char(10); break;
								case 1 : totalTime = BubbleSort_char(100); break;
								case 2 : totalTime = BubbleSort_char(1000); break;
								case 3 : totalTime = BubbleSort_char(10000); break;
									//case 4 : totalTime = BubbleSort_char(1000000); break;
								case 5 : totalTime = SelectionSort_char(10); break;
								case 6 : totalTime = SelectionSort_char(100); break;
								case 7 : totalTime = SelectionSort_char(1000); break;
								case 8 : totalTime = SelectionSort_char(10000); break;
									//case 9 : totalTime = SelectionSort_char(1000000); break;
								case 10 : totalTime = InsertionSort_char(10); break;
								case 11 : totalTime = InsertionSort_char(100); break;
							    case 12 : totalTime = InsertionSort_char(1000); break;
							    case 13 : totalTime = InsertionSort_char(10000); break;
								 	//case 14 : totalTime = InsertionSort_char(1000000); break;
								case 15: totalTime = QuickSort_char(10); break;
								case 16: totalTime = QuickSort_char(100); break;
								case 17: totalTime = QuickSort_char(1000); break;
								case 18: totalTime = QuickSort_char(10000); break;
									case 19: totalTime = QuickSort_char(1000000); break;
								case 20: totalTime = MergeSort_char(10); break;
								case 21: totalTime = MergeSort_char(100); break;
								case 22: totalTime = MergeSort_char(1000); break;
								case 23: totalTime = MergeSort_char(10000); break;
									case 24: totalTime = MergeSort_char(1000000); break;
								default :  break;
						}
						count++;
				}
				else
				{
						printf("Your input format are wrong!");
						exit(-1);
				}
		}
		else
		{
				printf("Your input format are wrong!");
				exit(-1);		
		}
		return totalTime;
}
void DataGenerate(int arraysize,char **argv)
{
		int lenth,rands;
		srand((unsigned) time(NULL));

		printf("Start Data Gernerating...            \t");
		if(argv[2][0] == 'n')
		{
				for(i=0;i<arraysize;i++)
				{
						tempint = rand();
						intdata[i] = tempint;
						intdata2[i]=intdata[i];
						//if(arraysize == 1000000 && i%10000 == 0)
						//		printf("Current Process : %d percents \n",i/10000);
				}
		}

		if(argv[4][0] == 's')
		{
				lenth = atoi(argv[2]);
				tempchar = (char*)malloc(sizeof(lenth));		

				for(i = 0;i < arraysize ;i++)
				{
						for(j = 0 ; j < lenth ; j++)
						{		
								rands = (int)(('0') + (rand()%124));
								while((rands >=58 && rands <=64) || (rands >=91&&rands<=96))
								{
									rands = (int)(('0')+(rand()%124));
								}
								buffer[j]=(char)( (int)('a') + ( rand()%26) );
								strcpy(tempchar,buffer);
								strcpy(strdata[i],tempchar);
								strcpy(strdata2[i],strdata[i]);
								//if(arraysize == 1000000 && i%100000 == 0)
										//printf("Current Process : %d \%\n",i/10000);
						}
						strdata[i][j]='\0';
						//printf("%d:%s ",i,strdata[i]);
				}
		}
		printf("Data Generated.\n");
}
float BubbleSort_char(int arraysize)
{
		int y = 0;
		printf("Start BubbleSort_char(%d)...     \t",arraysize);

		for(i=0;i<arraysize;i++)
				strcpy(strdata[i],strdata2[i]);

		startTime=clock();
		for(i=0;i<arraysize-1;i++)
		{
				for(j=0;j<arraysize-i-1;j++)
				{		
						y=0;
						do{
								tempint = strdata[j][y];
								tempint2 = strdata[j+1][y];
								y++;
						}while(tempint == tempint2);
						if(tempint > tempint2)
						{
								strcpy(tempchar,strdata[j]);
								strcpy(strdata[j],strdata[j+1]);
								strcpy(strdata[j+1],tempchar);
						}
					//	if(arraysize == 1000000 && i%100000 == 0)
					//			printf("Current Process : %d \%\n",i/10000);
				}
		}

		endTime=clock();
		//for(i=0;i<arraysize;i++)
		//		printf("%d:%s\n",i,strdata[i]);
		printf("BubbleSort_char(%d) Completed.\n",arraysize);
		return endTime-startTime;
}
float SelectionSort_char(int arraysize)
{
		int y,max;
		printf("Start SelectionSort_char(%d)...     \t",arraysize);
		for(i=0;i<arraysize;i++)
				strcpy(strdata[i],strdata2[i]);

		startTime = clock();
		for(i=0;i<arraysize;i++)
		{
				max = i;
				for(j=i+1;j<arraysize;j++)
				{
						y=0;
						do{
								tempint = strdata[j][y];
								tempint2 = strdata[max][y];
								y++;
						}while(tempint == tempint2);
						if(tempint>tempint2)
								max = j ;
				}
				strcpy(tempchar,strdata[max]);
				strcpy(strdata[max],strdata[i]);
				strcpy(strdata[i],tempchar);

			//	if(arraysize == 1000000 && i%100000 == 0)
			//			printf("Current Process : %d \%\n",i/10000);

		}

		endTime=clock();
		//for(i=0;i<arraysize;i++)
		//printf("%d:%s\n",i,strdata[i]);
		printf("SelectionSort_char(%d) Completed.\n",arraysize);
		return endTime-startTime;
}
float InsertionSort_char(int arraysize)
{
		int y=0;
		printf("Start InsertionSort_char(%d)...     \t",arraysize);
		for(i=0;i<arraysize;i++)
				strcpy(strdata[i],strdata2[i]);

		startTime = clock();
		for(i=1;i<arraysize;i++)
		{
				tempint = strdata[i][y];
				strcpy(tempchar,strdata[i]);
				//printf("tempchar = %s\n",tempchar);
				for(j=i-1;j>=0&& strdata[j][y]>tempint;--j)
				{
						tempint2 = strdata[j][y];
						y = 0;
						while(tempint ==tempint2){
								y++;
								tempint = strdata[i][y];
								tempint2 = strdata[j][y];
						};
						strcpy(strdata[j+1],strdata[j]);
						//printf("%c:%d << >> %c:%d \n",tempint2,tempint2,tempint,tempint);
				}
				strcpy(strdata[j+1],tempchar);

			//	if(arraysize == 1000000 && i%100000 == 0)
			//			printf("Current Process : %d \%\n",i/10000);

		}
		endTime = clock();

		//for(i=0;i<arraysize;i++)
				//printf("%d:%s\n",i,strdata[i]);
		printf("InsertionSort_char(%d) Completed.\n",arraysize);
		return endTime - startTime;
}
float BubbleSort_int(int arraysize)
{
		printf("Start BubbleSort_int(%d)...     \t",arraysize);

		for(i=0;i<arraysize;i++)
				intdata[i]=intdata2[i];

		startTime=clock();
		for(i=0;i<arraysize-1;i++)
		{
				for(j=0;j<arraysize-i-1;j++)
				{
						if(intdata[j]>intdata[j+1])
						{
								tempint=intdata[j];
								intdata[j]=intdata[j+1];
								intdata[j+1]=tempint;
						}
						//if(arraysize == 1000000 && i%100000 == 0)
								//printf("Current Process : %d \%\n",i/10000);
				}
		}

		endTime=clock();
		//for(i=0;i<arraysize;i++)
		//		printf("%d:%d\n",i,intdata[i]);
		printf("BubbleSort_int(%d) Completed.\n",arraysize);
		return endTime-startTime;
}
float SelectionSort_int(int arraysize)
{
		int max=0;
		printf("Start SelectionSort_int(%d)...     \t",arraysize);

		for(i=0;i<arraysize;i++)
				intdata[i]=intdata2[i];


		startTime=clock();
		for(i=0;i<arraysize;i++)
		{
				max = i;
				for(j=i+1;j<arraysize;j++)
				{
						if(intdata[j]>intdata[max])
								max = j ;

						tempint=intdata[max];
						intdata[max]=intdata[i];
						intdata[i]=tempint;

			//			if(arraysize == 1000000 && i%100000 == 0)
			//					printf("Current Process : %d \%\n",i/10000);
				}
		}

		endTime=clock();
		//for(i=0;i<arraysize;i++)
		//		printf("%d:%d\n",i,intdata[i]);
		printf("SelectionSort_int(%d) Completed.\n",arraysize);
		return endTime-startTime;
}
float InsertionSort_int(int arraysize)
{
		int count2;
		printf("Start InsertionSort_int(%d)...     \t",arraysize);

		for(i=0;i<arraysize;i++)
				intdata[i]=intdata2[i];
		startTime = clock();
		for(i=1;i<arraysize;i++)
		{
				tempint = intdata[i];
				for(j=i-1;j>=0&intdata[j]>tempint;--j)
				{
						intdata[j+1]=intdata[j];
				}
				intdata[j+1] = tempint;

				if(arraysize == 1000000 && i%100000 == 0)
						printf("Current Process : %d \%\n",i/10000);

		}
		endTime = clock();
		//for(i=0;i<arraysize;i++)
		//		printf("%d:%d\n",i,intdata[i]);
		printf("InsertionSort_int(%d) Completed.\n",arraysize);
		return endTime - startTime ;
}
float QuickSort_int(int arraysize)
{
	printf("Start QuickSort_int(%d)...\t\t",arraysize);
	for(i=0;i<arraysize;i++)
			intdata[i]=intdata2[i];
	startTime = clock();
	qsort(intdata,arraysize,sizeof(int),comp);
	endTime = clock();
	printf("QuickSort_int(%d) Complteted\n",arraysize);
	return endTime - startTime;

}
int comp(const void *p, const void *q)
{
	return ( * (int *) p = * (int *) q) ;
}
float QuickSort_char(int arraysize)
{
	printf("Start QuickSort_char(%d)...\t\t",arraysize);
	for(i=0;i<arraysize;i++)
			strcpy(strdata[i],strdata2[i]);
	startTime = clock();
	qsort(strdata,arraysize,sizeof(char **),compstr);
	endTime = clock();
	printf("QuickSort_char(%d) Complteted\n",arraysize);
	return endTime - startTime;
}
int compstr(const void *a,const void *b)
{
	return (strcmp((char *)a,(char *)b));
}
float MergeSort_int(int arraysize)
{
	printf("Start MergeSort_int(%d)...\t\t",arraysize);
	for(i=0;i<arraysize;i++)
		intdata[i]=intdata2[i];
	startTime = clock();
	mergesort(intdata,arraysize,sizeof(int),comp);
	endTime = clock();
	printf("MergeSort_int(%d) Complteted\n",arraysize);
	return endTime - startTime;
}
float MergeSort_char(int arraysize)
{
	printf("Start MergeSort_char(%d)...\t\t",arraysize);
	for(i=0;i<arraysize;i++)
				strcpy(strdata[i],strdata2[i]);
	startTime = clock();
	mergesort(strdata,arraysize,sizeof(char **),compstr);
	endTime = clock();
	printf("MergeSort_char(%d) Complteted\n",arraysize);
	return endTime - startTime;
}
