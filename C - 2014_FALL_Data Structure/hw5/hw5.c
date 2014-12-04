#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct list *listptr;
typedef struct list{
		int line;
		char linestr[1024];
		listptr next;
		listptr prev;
}element;

element data[1024];
listptr tmpelement;
listptr first,last,now,nxt,pre;

int tmpline=0;
char cmd[1024],tmpstr[1024];
FILE *fp;

int main(int argc,char **argv)
{
		//int tmpline=0;
		fp = fopen(argv[1],"r");
		if(fp==NULL){
				printf("Error on opening the file.\n");
				exit(-1);
		}
		else printf("File Successly Opened.\n");
		//start initialize data into linked list.

		tmpline=0;
		tmpelement =(listptr) malloc(sizeof(element));
		fgets(tmpstr,1024,fp);
		tmpelement->line = tmpline++;
		strcpy(tmpelement->linestr,tmpstr);
		tmpelement->prev=NULL;
		tmpelement->next=NULL;
		first=tmpelement;

		pre = tmpelement;
		tmpelement = (listptr)malloc(sizeof(element));
		fgets(tmpstr,1024,fp);
		tmpelement->line = tmpline++;
		strcpy(tmpelement->linestr,tmpstr);
		pre->next=tmpelement;
		tmpelement->prev=pre;
		tmpelement->next=NULL;

		while(fgets(tmpstr,1024,fp)!=NULL){

				pre = tmpelement;
				tmpelement = (listptr)malloc(sizeof(element));
				tmpelement->line = tmpline++;
				strcpy(tmpelement->linestr,tmpstr);
				pre->next=tmpelement;
				tmpelement->prev=pre;
				tmpelement->next=NULL;
		}//initailize complete

		fclose(fp);
		last=tmpelement;
		now=first;
		pre=NULL;

		printf(">");
		gets(cmd);
		while(cmd[0]!='q'){

				if(cmd[0]=='l'){
						if(cmd[1]=='\0')
								printf("  %d:%s",now->line,now->linestr);
						else if(cmd[2]=='.'){

								if(cmd[3]==','&&cmd[4]=='.'&&cmd[5]=='+'){

										int	tmpindex=0;
										char tmp2[7];
										while(cmd[6+tmpindex]!='\0'){
												tmp2[tmpindex]=cmd[6+tmpindex];
												tmpindex++;
										}
										tmp2[tmpindex]='\0';

										for(tmpindex=0;tmpindex<=atoi(tmp2);tmpindex++){
												if(now==NULL){
														printf("  Enter to long argument.\n");
														break;
												}
												else{
														printf("  %d:%s",now->line,now->linestr);
														pre = now;
														now = now ->next;
												}
										}
										now=pre;
										pre=now->prev;
										//printf("  %d:%s",now->line,now->linestr);

								}
								else printf("  Enter type should be .,.+(int).\n");

						}		
						else if(isdigit(cmd[2])){
								int	tmpindex=0;
								char tmp2[7];
								while(cmd[2+tmpindex]!='\0'){
										tmp2[tmpindex]=cmd[2+tmpindex];
										tmpindex++;
								}
								tmp2[tmpindex]='\0';

								for(tmpindex=0;tmpindex<atoi(tmp2);tmpindex++){
										if(now->next==NULL && tmpindex!=atoi(tmp2)-1){
												printf("  %d:%s",now->line,now->linestr);
												printf("  Enter to long argument.\n");
												break;
										}
										else{
												printf("  %d:%s",now->line,now->linestr);
												pre = now;
												now=now->next;
										}
								}
						}
						else if(cmd[2]=='a'){
								now = first;
								while(now){
										printf("  %d:%s",now->line,now->linestr);
										now = now->next;
								}
								now=first;
						}

						else 
								printf("  Command doesn't exists.\n");
				}
				else if(cmd[0]=='d'){
						if(cmd[1]=='\0'){
								if(pre==NULL){
										pre = NULL;
										now = now->next;
										first=now;
										now->prev=NULL;
										//free(pre);
										printf("  Deleted\n");
								}
								else{
										tmpelement=now;
										now=now->next;
										pre->next=now;
										now->prev=tmpelement->prev;
										tmpelement->prev->next=now;
										//free(tmpelement);
										printf("  Deleted.\n");
								}
								tmpline=now->line-1;
								while(now){
										now->line-=1;
										now=now->next;
								}
								now=first;
								while(now->line!=tmpline){
										pre=now;
										now=now->next;
								}
						}
						else if(cmd[2]=='.'){
								if(cmd[3]==','&&cmd[4]=='.'&&cmd[5]=='+'){
										int	tmpindex=0;
										char tmp2[7];
										while(cmd[6+tmpindex]!='\0'){
												tmp2[tmpindex]=cmd[6+tmpindex];
												tmpindex++;
										}
										tmp2[tmpindex]='\0';

										for(tmpindex=0;tmpindex<=atoi(tmp2);tmpindex++){
												if(now==NULL){
														printf("  Enter to long argument.\n");
														break;
												}
												else{
														if(now->next){
																if(pre){

																		now=now->next;
																		pre->next=now;
																		now->prev=pre;

																		tmpline=now->line-1;

																		while(now){
																				now->line-=1;
																				now=now->next;
																		}
																		now=first;
																		while(now&&now->line!=tmpline){
																				pre=now;
																				now=now->next;
																		}
																}
																else{
																		first=now->next;
																		now=first;
																		pre=NULL;

																		tmpline=now->line-1;
																		while(now){
																				now->line-=1;
																				now=now->next;
																		}
																		now=first;
																		while(now->line!=tmpline){
																				pre=now;
																				now=now->next;
																		}
																}

														}
												}
										}

								}
								else printf("  Enter type should be .,.+(int).\n");
						}						
						else if(isdigit(cmd[2])){

								int	tmpindex=0,tmp1,tmp2,tmpindex2;
								char tmpstr2[7],tmpstr3[7];
								while(cmd[2+tmpindex]!=','){
										tmpstr2[tmpindex]=cmd[2+tmpindex];
										tmpindex++;
								}
								tmpindex2=tmpindex+3;
								tmpstr2[tmpindex]='\0';
								tmp1=atoi(tmpstr2);

								tmpindex=0;
								while(cmd[tmpindex2+tmpindex]!='\0'){
										tmpstr3[tmpindex]=cmd[tmpindex2+tmpindex];
										tmpindex++;
								}
								tmpstr3[tmpindex]='\0';
								tmp2=atoi(tmpstr3);

								now = first;
								while(now->line!=tmp1){
										if(now!=NULL){
												pre=now;
												now=now->next;
										}
										else{
												printf("  Enter too long argument.\n");
												break;
										}
								}
								if(cmd[tmpindex2]=='$'){
										while(now){
												pre->next=now->next;
												now=now->next;
												free(pre);
										}
										now=first;
										printf("  Deleted to EOF.\n");
								}
								else{
										tmpelement = now;
										for(tmpindex=tmp1;tmpindex<=tmp2;tmpindex++){
												if(pre==NULL){
														pre = now;
														now = now->next;
														free(pre);
												}
												else{
														tmpelement=now;
														now=now->next;
														pre->next=now;
														free(tmpelement);

												}
										}
										while(now){
												now->line-=tmp2-tmp1+1;
												now=now->next;
										}
										now = first;
										printf("  %d line(s) Deleted.\n",tmp2-tmp1+1);
								}
						}								
						else 
								printf("  Command doesn't exist.\n");
				}
				else if(cmd[0]=='p'){

						if(pre){
								printf("  %d:%s",pre->line,pre->linestr);
								now=pre;
								pre=now->prev;
						}
						else 
								printf("  Previous data is NULL\n");
				}
				else if(cmd[0]=='n'){
						if(now->next){
								printf("  %d:%s",now->next->line,now->next->linestr);
								pre=now;
								now=now->next;
						}
						else
								printf("  Already in EOF.\n");
				}
				else if(cmd[0]=='s'){
						if(cmd[2]=='/'){
								int	tmpindex=0,tmpindex2=0,tmpint=0,i,j,k;
								char tmp2[1024],tmp3[1024];
								char final[1024]="",final2[1024];

								while(cmd[3+tmpindex]!='/'){
										tmp2[tmpindex]=cmd[3+tmpindex];
										tmpindex++;
								}
								tmp2[tmpindex]='\0';

								while(cmd[3+tmpindex]!='/'){
										tmp2[tmpindex]=cmd[2+tmpindex];
										tmpindex++;
								}
								tmp2[tmpindex]='\0';

								while(cmd[3+tmpindex+1+tmpindex2]!='/'){
										tmp3[tmpindex2]=cmd[3+tmpindex+1+tmpindex2];
										tmpindex2++;
										if(cmd[3+tmpindex+1+tmpindex2]=='\0')
												break;
								}
								tmp3[tmpindex2]='\0';

								//printf("%s %s",tmp2,tmp3);

								//now=first;
								strcpy(final,now->linestr);
								tmpint=0;
								if(cmd[strlen(cmd)-1]=='g'){
										now=first;
										while(now!=NULL){
												tmpint=0;
												if(now!=first){
														final[0]='\0';
														strcpy(final,now->linestr);
												}

												if(strstr(final,tmp2)!=NULL){//finds
break2:
														while(final[tmpint]!='\0'){
																if(final[tmpint]!=tmp2[0]);
																else{
																		for(i=0;i<strlen(tmp2);i++){
																				if(final[tmpint+i]!=tmp2[i])
																						break;
																		}
																		if(i==strlen(tmp2))
																				goto breaktwo;

																}
																tmpint++;
														}
breaktwo:
														if(i==strlen(tmp2)){
																//printf("hi");
																strncat(final2,final,tmpint);
																strcat(final2,tmp3);
																k=strlen(final2);	

																for(i=tmpint+i,j=0;i<strlen(final);i++,j++){
																		final2[j+k]=final[i];
																}
																final2[j+k]='\0';
																int jk=0;
																for(jk=0;jk<strlen(tmp2);jk++){
																		if(final[i+jk]!='\0'&&strstr(final2,tmp2)!=NULL)
																		{
																				final[0]='\0';
																				strcpy(final,final2);
																				final2[0]='\0';
																				//printf("%s \n",final);
																				goto break2;
																		}
																		else break;}

																free(now->linestr);
																strcpy(now->linestr,final2);
																printf("  Pattern Replaced\n");
																final2[0]='\0';
														}
														else{
																printf("  Pattern Not Founded.\n");
														}
												}
												else
												{printf("  Pattern Not Founded.\n");}
												now=now->next;
										}
										now=first;

								}
								else{

										final[0]='\0';
										strcpy(final,now->linestr);
										if(strstr(final,tmp2)!=NULL){//finds
breakl:
												while(final[tmpint]!='\0'){
														if(final[tmpint]!=tmp2[0]);
														else{
																for(i=0;i<strlen(tmp2);i++){
																		if(final[tmpint+i]!=tmp2[i])
																		{		break;	}
																}
																if(i==strlen(tmp2)){
																		goto breaktwo2;
																}
														}
														tmpint++;
												}
breaktwo2:
												if(i==strlen(tmp2)){
														strncat(final2,final,tmpint);
														strcat(final2,tmp3);
														k=strlen(final2);	

														for(i=tmpint+i,j=0;i<strlen(final);i++,j++){
																final2[j+k]=final[i];
														}
														final2[j+k]='\0';

														int jk=0;
														for(jk=0;jk<strlen(tmp2);jk++){
														
																		if(final[i+jk]!='\0'&&strstr(final2,tmp2)!=NULL)
																		{
																				final[0]='\0';
																				strcpy(final,final2);
																				final2[0]='\0';
																				goto breakl;
																		}
																		else break;
														}

																free(now->linestr);
																strcpy(now->linestr,final2);
																printf("  Pattern Replaced\n");
																final2[0]='\0';
														}
														else{
																printf("  Pattern Not Founded.\n");
														}
												}

										}
								}
								else
										printf("  Input should be \"s /pat1/pat2/(g)\"\n");
						}
						else if(cmd[0]=='R'){

								int	tmpindex=0;
								char tmp2[25];
								while(cmd[2+tmpindex]!='\0'){
										tmp2[tmpindex]=cmd[2+tmpindex];
										tmpindex++;
								}
								tmp2[tmpindex]='\0';
								fp=fopen(tmp2,"r");

								listptr tmpfornow = now->next;
								while(fgets(tmpstr,1024,fp)!=NULL){
										tmpelement = (listptr)malloc(sizeof(element));
										tmpelement->line = now->line+1;
										strcpy(tmpelement->linestr,tmpstr);
										now->next=tmpelement;
										tmpelement->prev=now;
										tmpelement->next=NULL;
										pre=now;
										now=now->next;
								}
								now->next=tmpfornow;
								int y = now->line;
								while(now->next)
								{
										now->line=y++;
										now=now->next;
								}
								last=now;
								now->line=y++;
								now=first;
								pre=NULL;
								//printf("%s",last->linestr);
								printf("  File:%s has add to data.\n",tmp2);
						}
						else if(cmd[0]=='w'){
								if(cmd[1]=='!'){

										fp=fopen(argv[1],"r+");
										if(!fp)
												printf("Cannot open the file.\n");
										now=first;

										while(now->next){
												fprintf(fp,"%s",now->linestr);
												now=now->next;
										}
										printf("Completed.\n");

								}
								else{
										int	tmpindex=0;
										char tmp2[7];
										while(cmd[2+tmpindex]!='\0'){
												tmp2[tmpindex]=cmd[2+tmpindex];
												tmpindex++;
										}
										tmp2[tmpindex]='\0';
										fp=fopen(tmp2,"w+");
										now=first;
										while(now->next!=NULL){
												fprintf(fp,now->linestr,100);
												now=now->next;
										}
										printf("Completed.\n");
								}
								fclose(fp);
						}
						else if(cmd[0]=='f'){

								int	tmpindex=0;
								char tmp2[7];
								while(cmd[3+tmpindex]!='"'){

										tmp2[tmpindex]=cmd[3+tmpindex];
										tmpindex++;
								}
								tmp2[tmpindex]='\0';
								tmpindex=now->line;
								now=first;
								while(now!=NULL && strstr(now->linestr,tmp2)==NULL){
										pre=now;
										now=now->next;
								}
								if(now!=NULL)
										printf("  %d:%s",now->line,now->linestr);
								else{
										printf("Pattern not founded.\n");
										now=first;
										while(now->line!=tmpindex){
												pre=now;
												now=now->next;
										}								
								}
						}
						else if(cmd[0]=='g'){
								if(cmd[2]=='$'){
										now=last;
										pre=last->prev;
										printf("  %d:%s",last->line,last->linestr);
								}
								else if(isdigit(cmd[2])){

										int	tmpindex=0;
										char tmp2[7];
										while(cmd[2+tmpindex]!='\0'){
												tmp2[tmpindex]=cmd[2+tmpindex];
												tmpindex++;
										}
										tmp2[tmpindex]='\0';
										now=first;
										while(now!=NULL && now->line!=atoi(tmp2)){
												pre=now;
												now=now->next;
										}
										if(now!=NULL && now->line==atoi(tmp2))
												printf("  %d:%s",now->line,now->linestr);
										else{
												printf("  No Such line.\n");
												now=last;
										}
								}
						}
						else if(cmd[0]=='i')
						{
								tmpelement = (listptr)malloc(sizeof(element));
								int	tmpindex=0;
								char tmp2[1024];
								while(cmd[3+tmpindex]!='"'){

										tmp2[tmpindex]=cmd[3+tmpindex];
										tmpindex++;
								}
								tmp2[tmpindex]='\n';
								tmp2[tmpindex+1]='\0';

								strcpy(tmpelement->linestr,tmp2);
								tmpelement->line=now->line+1;
								pre=now;
								now=tmpelement;
								tmpelement->prev=now;
								tmpelement->next=pre->next;
								now->next=pre->next;
								pre->next=now;

								if(now->next)
										now=now->next;
								else 
										last=now;

								while(now->next){
										now->line+=1;
										now=now->next;
								}
								now=first;
								printf("  Insert Finished.\n");
						}
						else if(strcmp(cmd,"")==0);
						else
								printf("Command doesn't exists.\n");


						printf(">");
						cmd[0]='\0';
						gets(cmd);
				}


				printf("Program Exited.\n");
				return 0;
		}
