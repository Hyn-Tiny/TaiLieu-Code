#include <iostream>
using namespace std;

//Compiler version g++ 6.3.0
class queue
{
  private:
    struct Node
    {
      int Infor;
      Node *Link;
    };
    2:
    void QInsert(int x);
    int QDelete();
    int QIsEmpty();
};

//int Front(Queue HD);
//int Rear(Queue HD);

int main()
{
    queue HD1;
    queue HD2;
    /*int x;
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
   */ cout << "Hello, Dcoder!";
   return 0;
}
void queue::QInsert(int x)
{
  Node *N=new Node;
  N->Infor=x;
  N->Link=NULL;
  if(F==NULL)
  {
    F=R=N;
  }
  else
  {
    R->Link=N;
    R=N;
  }
}
int queue::QDelete()
{
  if(F==NULL)
  {
    cout<<"hang doi rong";
    return -1;
  }
  int tg=F->Infor;
  Node *P=F;
  if(F==R)
  {
    F=R=NULL;
  }
  else
  {
    F=F=NULL;
  }
  delete P;
  return tg;
}
int queue::QIsEmpty()
{
  if(F==NULL) return 1;
  return 0;
}
/*
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
}*/