#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct data
{
		char name[100];
		char birth[130];
		char phone[100];
		char mail[300];
		struct data *p;
};
char *getword(char *line,char *word);
int checkcases(char argvs[]);
void load(char filename[]);
struct data *temp,*top,*now,*pre,*list[1000];
FILE *fp; 
char line[500],word[500],*tempforchar;
int number;
void listing(char filename2[]);
void find(char filename3[]);
void sort(char filename4[]);
void add(char filename4[],char filename5[]);
int main(int argc , char **argv)
{	
		int cases = 0 ;
		number =0;
		top = NULL;
		if(argc < 3) 
				printf("ERROR");
		cases = checkcases(argv[1]);
		if(cases <=0 || cases >4)
		{
				printf("ERROR\n");
				exit(0);
		}

		load(argv[argc-1]);

		switch(cases)
		{
				case 1 : listing(argv[argc-1]); break;
				case 2 : find(argv[argc-2]); break;
				case 3 : sort(argv[argc-2]); break;
				case 4 : add(argv[argc-2],argv[argc-1]); break;
				default: break;	
		}

		fclose(fp);
		return 0;

}
void load(char filename[])
{
		int y = 0;
		fp = fopen(filename,"r");
		if(fp == NULL)
				printf("Cannot open this file.");
		else
		{
				while(fgets(line,500,fp)!=NULL)
				{
						temp = (struct data *)malloc(sizeof(struct data));
						list[number] = temp;
						number++;		
						tempforchar = line;

						for(y=1;y<5;y++)
						{
								tempforchar = getword(tempforchar,word);
								if(y == 1)
										strcpy(temp->name,word);
								else if(y == 2)
										strcpy(temp->birth,word);
								else if(y == 3)
										strcpy(temp->phone,word);
								else if(y == 4)
										strcpy(temp->mail,word);
								else
										break;		
						}
						now = top;

						do{			
								if(top == NULL)
								{
										top = temp ;
										top->p = NULL;		
										break;	
								}
								else if(now == NULL)
								{				
										pre->p = temp;
										now = pre->p;
										now->p = NULL; 	
										break;
								}
								pre = now ;
								now = now->p;

						}while(pre);

				}
				fclose(fp);
		}

}
int checkcases(char argvs[])
{
		if(argvs[0] == '-')
		{
				if(argvs[1] == 'l')
						return	1;
				else if(argvs[1] == 'f')
						return	2;
				else if(argvs[1] == 's')
						return	3;
				else if(argvs[1] == 'a')
						return	4;
				else
						return 0;
		}
		else
				return 0;
}
char *getword(char *line,char *word){
		if(*line=='\t')line++;
		while(*line=='\n'||*line==' ') line++;
		if(*line=='\0') return NULL;
		while(*line!='\t'&&*line!='\n'&&*line!=' '&&*line!='\0'){
				*word=*line;
				word++;
				line++;
		}
		*word='\0';
		return line;
}
void listing(char filename2[])
{
		printf("==================================================================\n");
		printf("Name\tBirthday\tPhone\t\tE-mail\n","Name","Birthday","Phone","E-mail");
		fp = fopen(filename2,"r");
		if(fp == NULL)
				printf("Cannot open this file.");
		else
		{
				while(fgets(line,500,fp))
				{
						printf("%s",line);
				}
		}
		printf("==================================================================\n");
}
void find(char filename3[])
{
		int h=0,j=0;
		for(h=0;h<number;h++)
		{
				//if(strcmp(list[h]->name,filename3)==0)
				if( strstr(list[h]->name,filename3)!=NULL || strstr(list[h]->phone,filename3)!=NULL || strstr(list[h]->birth,filename3)!=NULL || strstr(list[h]->mail,filename3)!=NULL )
				{			
						printf("%s\t %s\t %s\t %s\n",list[h]->name, \
										list[h]->birth,list[h]->phone,list[h]->mail);
				}
				else
						j++;	
		}
		if(j == number)
				printf("Data Not Found.\n");

}
void sort(char filename4[])
{
		int ip,pi,h=0;
		//if(filename4[0] == '-')
		//{
		for(ip=0;ip<number;ip++)
		{
				for(pi=0;pi<number-ip-1;pi++)
				{
						if(strcmp(list[pi]->name,list[pi+1]->name)<0)
						{
								temp = list[pi] ;
								list[pi] = list[pi+1] ;
								list[pi+1] = temp ;
						}
				}		
		}
		if(filename4[0] == '-')
		{
				if(filename4[1] == 'i')
				{
						top = list[number-1];
						now = top;
						for(h=number-1;h>=0;h--)
								printf("%s\t%s\t%s\t%s\n",list[h]->name, \
												list[h]->birth,list[h]->phone,list[h]->mail);

				}
				else if(filename4[1] == 'd')
				{
						top = list[0];
						now = top;
						for(h=0;h<number;h++)
								printf("%s\t%s\t%s\t%s\n",list[h]->name, \
												list[h]->birth,list[h]->phone,list[h]->mail);
				}
				else
				{
		top = list[number-1];
						now = top;
						for(h=number-1;h>=0;h--)
								printf("%s\t%s\t%s\t%s\n",list[h]->name, \
												list[h]->birth,list[h]->phone,list[h]->mail);




				}

		}
		else
		{
		top = list[number-1];
						now = top;
						for(h=number-1;h>=0;h--)
								printf("%s\t%s\t%s\t%s\n",list[h]->name, \
												list[h]->birth,list[h]->phone,list[h]->mail);




		}

}

void add(char filename4[],char filename5[])
{		

		temp = (struct data *)malloc(sizeof(struct data));
		tempforchar = filename4;
		tempforchar = getword(tempforchar,word);
		strcpy(temp->name,word);
		if( strstr(temp->name,"/") != NULL || strstr(temp->name,"09")!= NULL || strstr(temp->name,"@")!= NULL)
		{printf("ERROR\n"); exit(-1);}
		while( (tempforchar = getword(tempforchar,word) ) != NULL)
		{
				if(strstr(word,"/") != NULL)
						strcpy(temp->birth,word);
				else if(strstr(word,"09") != NULL)
						strcpy(temp->phone,word);
				else if(strstr(word,"@") != NULL)
						strcpy(temp->mail,word);			
				else{}
		}
		printf("p:%d b:%d\n",strlen(temp->phone),strlen(temp->birth));
		//	printf("%s ends",temp->phone);
		if(strlen(temp->phone)!=10)		
		{
				printf("ERROR:phone\n"); exit(-1);}	
		
		if(strlen(temp->birth)!=0){
		if(strlen(temp->birth)!=10)
		{printf("ERROR:birth\n"); exit(-1);}
}

		if(strstr(temp->phone,"09") == NULL)
		{printf("ERROR\n"); exit(-1);}

		now = top;
		while(now)
		{
				pre=now;
				now=now->p;
		}
		pre->p=temp;
		temp->p=NULL;

		fp=fopen(filename5,"at+");
		if(fp!=NULL)
		{				now=top->p->p;
				/*while(now)
				{
						// printf("%s\t%s\t%s\t%s\n",now->name, \
						now->birth,now->phone,now->mail);
					printf("%s\n",temp->name);
					fprintf(fp,"%s\t%s\t%s\t%s\n",now->name, \
										now->birth,now->phone,now->mail);
						now=now->p;
				}*/
				
				
				//printf("%s\n",temp->name);
				fprintf(fp,"%s\t%s\t%s\t%s\n",temp->name, \
										temp->birth,temp->phone,temp->mail);
				
//				for(kp=0;kp<strlen(filename5);kp++)
//				{
//						if(filename5[kp] == ' ')
//								filename[kp]='\t';
//				}
				printf("%s Has Been Writen.\n",filename4);
				fclose(fp);
		}
		else
		{
				printf("Cannot open this file.\n");
		}
}

