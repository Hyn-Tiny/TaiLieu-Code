#include <iostream>
using namespace std;

//Compiler version g++ 6.3.0

class Queue
{
  private:
    enum{size=10};
    int F,R;
    int Q[size];
  public:
    void CQInsert(int x);
    int CQDelete();
    int IsEmoty();
};


int main()
{
  Queue HD;
    cout << "Hello, Dcoder!";
}

void Queue::CQInsert(int x)
{
  if((F==0)&&(R==size-1) ||(R+1==F))
  {
    cout<<"hang doi day";
    return;
  }
  if(R=-1){
    F=R=0;
  }
  else if(R==size-1){
    R=0;
  }
  else
  {
    R++;
  }
  // dua ra
  Q[R]=x;
}

int Queue::CQDelete()
{
  if((F==-1)&&(R==-1))
  {
    cout<<"hang doi rong";
    return -1;
  }
  int tg=Q[F];
  if(F==R)
  {
    F=R=-1;
  }
  else if(F==size-1)
  {
    F=0;
  }
   else
    {
      F++;
    }
}
int Queue::IsEmoty()
{
  if((F==-1)&&(R==-1))
  {
    cout<<"hang doi rong";
    return 1;
  }
  return 0;
}
