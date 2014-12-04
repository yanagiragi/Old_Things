#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <time.h>

FILE *fp;
char *tempchar,*tempchardata,*pop,*strdata,line[1024],word[1024],*n;
// tempchardata for malloc throw to strdata
char cc[1000][1000]={" "},strs[1024]="./a.out -i ";
float str,end;
int f_status = 0,i,f,m,ff,count; //i : tempint ; f: control startingprocess ; m: for -m func.
int Finds=0; // 0 is not found. 1 is found.
char calcal(char *a,char argvc,char pat[1024]);
void startingprocess(int argc,char **argv);
char *getword(char *line,char *word);
int mystrtsr(char *line,char *word);
int main( int argc,char ** argv)
{
		if( argv[1][0] != '-')
		{
				printf("Wrong Input.\n");
				exit(-1);
		}
		else
		{		if(argv[1][1]== 'R') 
				{
									strcat(strs,argv[2]);
									strcat(strs," *");
									printf("%s\n",strs);
									system(strs); 
				}		
				startingprocess(argc,argv);
		}
		exit(-1);
		return 0;
}
void startingprocess(int argc,char **argv)
{
		f = 3;
		while(f<argc)
		{
				switch(argv[1][1])
				{
						case 'i': calcal(argv[f],'i',argv[2]); break;
						case 'v': calcal(argv[f],'v',argv[2]); break;
						case 'n': calcal(argv[f],'n',argv[2]); break;
						case 'l': 	
								  f_status = calcal(argv[f],'l',argv[2]); 
								  if(f_status ==1) printf("Matched: %s\n",argv[f]); 
								  else printf("Not Matched: %s\n",argv[f]);
								  f_status=0;	break;
						case 'h': calcal(argv[f],'h',argv[2]); break;
						case 'w': calcal(argv[f],'w',argv[2]); break;
						case 'x': calcal(argv[f],'x',argv[2]); break;
						case 'c': calcal(argv[f],'c',argv[2]); printf("%s Matches: %d cases.\n",argv[f],i); break;
						case 'm': m = atoi(argv[2]); if(f == argc-1) {break;} calcal(argv[f+1],'m',argv[3]); break;
						case 'b': calcal(argv[f],'b',argv[2]); break;
						case 'p': calcal(argv[f],'p',argv[2]); break;
						case 'A':
								  if(f+1!=argc)
								  {
										  f++; m=atoi(argv[2]);
										  calcal(argv[f],'A',argv[3]);
										  break;
								  }
						case 'B':
								  if(f+1!=argc)
								  {
										  f++; m=atoi(argv[2]);
										  calcal(argv[f],'B',argv[3]);
										  break;
								  }
						default : printf("Wrong Input.\n"); exit(-1);
				}
				f++;
		}
}
char calcal(char *a,char argvs,char pat[1024])
{
		//a:filename;argvs:which function(i,v,n...);pat:pattern to search
		fp = fopen(a,"r");
		if(fp!=NULL) 	printf("\n==================== Greping %s...  \n",a);
		else {printf("Error Occured On File : %s!\n",a); return 0;}

		tempchardata = (char *)malloc((sizeof(1024))); //exceeded 1024 overflow?
		strdata = tempchardata;

		if(argvs == 'i')
		{
				int i=0;
				printf("\n");
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strcasestr(strdata,pat);
						if(tempchar == NULL);
						else printf("%s -> %s\n",a,strdata);
				}
				printf("==================== Grep END. \n");
		}
		else if(argvs == 'v')
		{

				printf("\n");
				while(fgets(strdata,1024,fp) != NULL)
				{
						//fgets(strdata,1024,fp);
						tempchar = strstr(strdata,pat);
						if(tempchar == NULL)
								printf("%s -> %s\n",a,strdata);
				}
				printf("==================== Grep END. \n");
		}
		else if(argvs =='n')
		{
				i=1;
				//printf("%d\n",i);
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar == NULL);
						else printf("%s -> line:%d %s\n",a,i,strdata);
						i++;	
				}
				printf("==================== Grep END. \n");
		}
		else if(argvs == 'l')
		{
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar == NULL);
						else return 1;	
				}
				return 0;

		}
		else if(argvs =='h')
		{
				printf("\n");
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar == NULL);
						else printf(" -> %s\n",strdata);
				}
				printf("==================== Grep END. ==================\n");
		}
		else if(argvs == 'w')
		{
				while(fgets(strdata,1024,fp)!=NULL)
				{ 
						tempchardata = strdata;
						while(tempchardata !=NULL)
						{
								tempchardata = getword(tempchardata,word);
								if(tempchardata == NULL) break;
								if(strcmp(word,pat)==0) 
								{
										printf("%s -> %s\n",a,strdata);
										break;
								}
						}
				}
		}
		else if(argvs == 'x')
		{
				printf("\n");
				while(fgets(strdata,1024,fp) != NULL)
				{
						if(strncmp(strdata,pat,strlen(pat))==0)
								printf("%s -> %s\n",a,strdata);
				}
				printf("==================== Grep END. ==================\n");
		}
		else if (argvs =='c')
		{
				i=0;
				printf("\n");
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar == NULL);
						else i++;
				}
				printf("==================== Grep END. ==================\n");
		}
		else if(argvs == 'm')
		{
				i=0;
				printf("\n");
				while(fgets(strdata,1024,fp) != NULL && i!=m)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar == NULL);
						else 
						{
								i++;
								printf("%s -> %s\n",a,strdata);
						}		
				}
				printf("==================== Grep END. ==================\n");
		}
		else if(argvs =='b')
		{	i=0;
				printf("\n");
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar == NULL);
						else 
								m = 1;
						if(m==1)
						{
								printf("%d -> %s\n",i,strdata);
								m=0;
						}

						if(m!=1)
								i = i + strlen(strdata);
				}
				printf("==================== Grep END. ==================\n");

		}		
		else if(argvs == 'p')
		{
				float rr,kk;
				int yp,yl;
				printf("\n");
				while(fgets(strdata,1024,fp)!= NULL)
				{
						tempchardata = strdata;
						tempchar = pat;

						str = clock();
						pop = strstr(tempchardata,tempchar);
						end = clock();
						rr+=(end-str)/CLOCKS_PER_SEC;
						if(pop!=NULL)
								yp=1;
						else;

						str = clock();
						Finds = mystrstr(tempchardata,tempchar);
						end = clock();
						kk+=(end-str)/CLOCKS_PER_SEC;
						if(Finds==1)
								yl=1;
						else;
				}
				if(yp==1 && yl==1)
						printf("  strstr founded: %f sec.\nmystrstr founded: %f sec.\n",rr,kk);
				printf("==================== Grep END. ==================\n");
		}
		else if(argvs == 'A')
		{
				printf("\n");
				i=0;
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar != NULL) //find
						{
								//printf("-> %s\n",strdata);
								
								ff = m-i;
								i-=1;
								for(;i>=0;i--)
								  printf("-> %s\n",cc[i]);
								if(ff==0);
								else
								  for(i=9;i>=ff;i--)
								  	printf("-> %s\n",cc[i]);
								 
								printf("-> %s\n",strdata);
								break;
						}
						else 
						{	
								if(i<m-1)
								{	
										for(count=0;count<=strlen(strdata);count++)
												cc[i][count] = *(strdata+count);
										i++;
								}
								else
								{
										i=0;
										for(count=0;count<=strlen(strdata);count++)
												cc[i][count] = *(strdata+count);
										i++;
								}
								//printf("%s\n",cc[i]);
						}
				}
				printf("==================== Grep END. ==================\n");
		}
		else if(argvs =='B')
		{
				//m = 0;
				printf("m=%d\n",m);
				while(fgets(strdata,1024,fp) != NULL)
				{
						tempchar = strstr(strdata,pat);
						if(tempchar != NULL)
						{
								printf("-> %s\n",strdata);
								break;
						}
				}
				for(i=0;i<m;i++)
				{
						printf("-> %s\n",fgets(strdata,1024,fp));
				}
				printf("==================== Grep END. ==================\n");
		}

		else
				printf("Error.\n");

		fclose(fp);

		/*printf("\n");
		  while(fgets(strdata,1024,fp) != NULL)
		  {
		  tempchar = strstr(strdata,pat);
		  if(tempchar == NULL);
		  else printf("-> %s\n",strdata);
		  }
		  printf("==================== Grep END. ==================\n");
		 */
}
char *getword(char *line,char *word)
{
		while(*line == ' '||*line=='\n'||*line==','||*line=='.') line++;
		if(*line == '\0') return NULL;
		while(*line !='\n' && *line != ' '&&*line!=','&&*line!='.')
		{
				*word = *line;
				word++;
				line++;
		}
		*word='\0';
		return line;
}
int mystrstr(char *line,char *word)
{
		int cc,d;

		for(cc=0;cc<strlen(line);cc++)
		{
				if(line[cc]==word[0])
				{
						for(d=1;d<strlen(word);d++)
						{
								if(line[cc+d]!='\0' && d!=strlen(word)-1)
								{
										if(line[cc+d]==word[d]);
										else break;
								}
								if(line[cc+d]!='\0'&& d==strlen(word)-1)
								{
										if(line[cc+d]==word[d])
										{
												return 1;
										}
								}
						}

				}
		}
		return 0;
}
