#include <iostream>
using namespace std;

//Compiler version g++ 6.3.0
#define N 50
struct Queue
{
  int F,R;
  int Q[N];
};
void CQInsert(Queue &HD,int x);
int CQDelete(Queue &HD);
int IsEmoty(Queue HD);

int main()
{
  Queue HD={-1,-1};
    cout << "Hello, Dcoder!";
}
void CQInsert(Queue &HD,int x)
{
  if((HD.F==0)&&(HD.R==N-1) ||(HD.R+1==HD.F))
  {
    cout<<"hang doi day";
    return;
  }
  if(HD.R=-1){
    HD.F=HD.R=0;
  }
  else if(HD.R==N-1){
    HD.R=0;
  }
  else
  {
    HD.R++;
  }
  // dua ra
  HD.Q[HD.R]=x;
}
int CQDelete(Queue &HD)
{
  if((HD.F==-1)&&(HD.R==-1))
  {
    cout<<"hang doi rong";
    return -1;
  }
  int tg=HD.Q[HD.F];
  if(HD.F==HD.R)
  {
    HD.F=HD.R=-1;
  }
  else if(HD.F==N-1)
  {
    HD.F=0;
  }
   else
    {
      HD.F++;
    }
}
int IsEmoty(Queue HD)
{
  if((HD.F==-1)&&(HD.R==-1))
  {
    cout<<"hang doi rong";
    return 1;
  }
  return 0;
}
