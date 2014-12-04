#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define true 1
#define false 0

typedef struct
{
		int key;
}element;
typedef struct
{
		char oper;
}element2;

element stack[1024];
element2 stack2[1024];
int capacity=1,capacity2=1;
int top=-1,top2=-1;
int flag=1;
char ST_stat;
int length=0; // length of argv[2]

void status_start(char **argv);
void push(element item);
void push2(element2 item);
void stackFull();
void stackEmpty();
void infixtopostfix(char *argv);
int what_operator(char op);
int operator_order(char symbol);
element pop();
element2 pop2();

void stackEmpty()
{
		//printf("Stack is empty,cannot pop element\n");
		printf("aERROR\n");
		exit(-1);
}
void stackFull()
{
		fprintf(stderr,"Stack is full,cannot add element");
		exit(EXIT_FAILURE);
}
element pop()
{
		if(top==-1)
				stackEmpty();	//return stackEmpty();
		return stack[top--];
}
element2 pop2()
{
		if(top2==-1)
				stackEmpty();
		return stack2[top2--];		
}
void push(element item)
{
		if(top >= 1024)
				stackFull();
		stack[++top] = item;		
}
void push2(element2 item)
{
		if(top >= 1024)
				stackFull();
		stack2[++top2] = item;		
}
int what_operator(char op)
{
		switch(op)
		{
				case '(' : return 0;
				case ')' : return 1;
				case '+' : return 2;
				case '-' : return 3;
				case '*' : return 4;
				case '/' : return 5;
				case ' ' : return 6;
				default  : return 7;
						   break;
		}
}
int operator_order(char symbol)
{
		switch(symbol){
				case '(' : return 0;
				case ')' : return 0;
				case '*' : return 1;
				case '/' : return 1;
				case '+' : return 2;
				case '-' : return 2;
				//case '@' : return -1;
		}
}
void infixtopostfix(char *argv)
{
		int i,tmp,ip,num,finalnum=0;
		char sym;
		int opercount=0;
		element2 tempele2;
		top2=0;
		stack2[0].oper= '@';
		printf("Infix_To_Postfix =");

		for(i=0;i<length;i++){
					//printf(" ");
						if(what_operator(argv[i])==7){
							if(isdigit(argv[i])){
								finalnum=0; tmp=0; num=0;
								while(isdigit(argv[i+1])){
										tmp++; i++;
								}
								tmp++;
								for(ip=0;ip<tmp;ip++){
										num=argv[i-tmp+ip+1]-'0';
										finalnum=finalnum*10+num;
								}
						
								printf("%d ",finalnum);
							}
							else{
								
								if(i!=length-1 && !(argv[i+1]==' ' ||  argv[i+1]=='+' || argv[i+1] =='-' || argv[i+1]=='*' ||argv[i+1] =='/'))	printf("%c",argv[i]);
								else printf("%c ",argv[i]);
						}}
				else if(what_operator(argv[i])== 1){
						while(stack2[top2].oper != '(' )
								printf("%c ",pop2().oper);
						pop2();
				}
				else if(what_operator(argv[i]) == 6);
				else{
						//if(top2==0) printf(" ");
						while(stack2[top2].oper!='@' && operator_order(stack2[top2].oper) <= operator_order(argv[i]) )
								printf("%c ",pop2().oper);
							
						tempele2.oper=argv[i];
						push2(tempele2);
				}

		}
		while(top2!=0)
				printf("%c ",pop2().oper);
		printf("\n");
}
int main(int argc,char **argv)
{
		char *tempchar="";
		int cf;
		if(argv[1][0]=='-')
				ST_stat=argv[1][1];

		tempchar=argv[2];
		while(*tempchar !='\0')
		{
				if(*tempchar=='(') flag=0;
				if(isdigit(*tempchar) && !(isdigit(*(tempchar+1)))) cf++;
				if(!isdigit(*tempchar) && cf ==1 && *tempchar!= '(' && *tempchar !=' ') flag=0;
				tempchar++; length++;
		}
		status_start(argv);

		return 0;
}
void status_start(char **argv)
{
		int i=0;

		if(ST_stat=='e')
		{
				if(flag==1)
				{
				//		printf("Postfix! %s\n",argv[2]);
						for(i=0;i<length;i++){

								if(isdigit(argv[2][i])){
										int tmp=0,num=0,ip,finalnum=0;
										element temp;
										while(isdigit(argv[2][i+1])){
												tmp++; i++;
										}
										tmp++;
										for(ip=0;ip<tmp;ip++){
												num=argv[2][i-tmp+ip+1]-'0';
												finalnum=finalnum*10+num;
										}
										temp.key=finalnum;
										push(temp);
								}
								else{
										//printf("%c\n",argv[2][i]);
										int t1,t2;
										element temp;
										switch( what_operator(argv[2][i])){
												case 0 :
												case 1 : 
														printf("Error.\n");
														break;
												case 2 :
														t1 = pop().key;
														t2 = pop().key;
														temp.key = t2+t1;
														push(temp); break;
												case 3:
														t1 = pop().key;
														t2 = pop().key;
														temp.key = t2-t1;
														push(temp); break;
												case 4: 
														t1 = pop().key;
														t2 = pop().key;
														temp.key = t2*t1;
														push(temp); break;
												case 5:
														t1 = pop().key;
														t2 = pop().key;
														if(t1==0) {printf("ERROR\n"); exit(-1);}
														temp.key = t2/t1;
														push(temp); break;
												case 6: 
														break;
										}
								}//end else
						}//end for
						//printf("top=%d\n",top);
						if(top==0)
						printf("Calculation Result = %d\n",pop().key);
						else
								printf("ERROR\n");
				}// end postfix calculation

				else { // if (flag ==0) >> infix

						//printf("Infix!\n");
						int i,tmp,ip,num,finalnum=0;
						char sym,*buffer="";
						int opercount=0;
						element2 tempele2;
						top2=0;
						stack2[0].oper= '@';
						char finalstr[1024]="./a.out -e \"";
						int strindex=12;

						for(i=0;i<length;i++){
								if(isdigit(argv[2][i])){
										finalnum=0; tmp=0; num=0;
										finalstr[strindex++]=argv[2][i];
										while(isdigit(argv[2][i+1])){
												finalstr[strindex++]=argv[2][i+1];
												i++;
										}
										
										finalstr[strindex++]=' ';
								}
								else if(what_operator(argv[2][i])== 1){
										while(stack2[top2].oper != '(' )
												finalstr[strindex++]=pop2().oper;
										
									pop2();
								}
								else if(what_operator(argv[2][i]) == 6);
								else{
										while(top2!=0 && operator_order(stack2[top2].oper) <= operator_order(argv[2][i]) )
												finalstr[strindex++]=pop2().oper;
										tempele2.oper=argv[2][i];
										push2(tempele2);
								}

						}
						//printf("aa");
						while(top2!=0)
								finalstr[strindex++]=pop2().oper;
						finalstr[strindex++]='\"';
						finalstr[strindex++]='\0';
						//printf("%s\n",finalstr);
						system(finalstr);
				}

		}
		else if(ST_stat =='t')
				infixtopostfix(argv[2]);


		else{
				printf("Error.\n");
				exit(-1);
		}
}
