#include <iostream>
using namespace std;

//Compiler version g++ 6.3.0
struct Node
{
  int Infor;
  Node *Link;
};
struct Queue
{
  Node *F,*R;
};

void QInsert(Queue &HD, int x);
int QDelete(Queue &HD);
int QIsEmpty(Queue HD);
int Front(Queue HD);
int Rear(Queue HD);

int main()
{
    Queue HD1={NULL, NULL};
    Queue HD2={NULL, NULL};
    int x;
    while(cin>>x)
    {
      cout<<x<<" ";
      if(x%2==0)QInsert(HD2,x);
      else QInsert(HD1,x);
    }
    cout<<"day so le ";
    while(!QIsEmpty(HD2))cout<<QDelete(HD2);
    cout<<"day so chan";
    while(!QIsEmpty(HD1))cout<<QDelete(HD1);
    cout << "Hello, Dcoder!";
}
void QInsert(Queue &HD, int x)
{
  Node *N=new Node;
  N->Infor=x;
  N->Link=NULL;
  if(HD.F==NULL)
  {
    HD.F=HD.R=N;
  }
  else
  {
    HD.R->Link=N;
    HD.R=N;
  }
}
int QDelete(Queue &HD)
{
  if(HD.F==NULL)
  {
    cout<<"hang doi rong";
    return -1;
  }
  int tg=HD.F->Infor;
  Node *P=HD.F;
  if(HD.F==HD.R)
  {
    HD.F=HD.R=NULL;
  }
  else
  {
    HD.F=HD.F=NULL;
  }
  delete P;
  return tg;
}
int QIsEmpty(Queue HD)
{
  if(HD.F==NULL) return 1;
  return 0;
}
int Front(Queue HD)
{
  if(HD.F==NULL)
  {
    cout<<"hang doi rong";
    return -1;
  }
  return HD.F->Infor;
}
int Rear(Queue HD)
{
    if(HD.R==NULL)
  {
    cout<<"hang doi rong";
    return -1;
  }
  return HD.R->Infor;
}