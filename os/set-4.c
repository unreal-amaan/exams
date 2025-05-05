// TASK-1************************************************************

#include <stdio.h>
struct sq
{
    char pro[10];
    int bt, wt, prior, tat;
} P[10], temp;
void main()
{
    int i, j, n, temp1 = 0;
    float awt = 0, atat = 0;
    printf("Enter no. of processes\n");
    scanf("%d", &n);
    printf("enter name, burst time, priority\n");
    for (i = 0; i < n; i++)
    {
        scanf("%s%d%d", P[i].pro, &P[i].bt, &P[i].prior);
    }
    for (i = 0; i < n; i++)
    {
        for (j = i + 1; j < n; j++)
        {
            if (P[i].prior > P[j].prior)
            {
                temp = P[i];
                P[i] = P[j];
                P[j] = temp;
            }
        }
    }
    for (i = 0; i < n; i++)

    {
        P[i].wt = temp1;
        P[i].tat = P[i].wt + P[i].bt;
        temp1 += P[i].bt;
    }
    for (i = 0; i < n; i++)
    {
        awt += P[i].wt;
        atat += P[i].tat;
    }
    printf("process\tbt\twt\ttat\n");
    awt /= n;
    atat /= n;
    for (i = 0; i < n; i++)
    {
        printf("%s\t%d\t%d\t%d\n", P[i].pro, P[i].bt, P[i].wt, P[i].tat);
    }
    printf("awt=%f\n,atat=%f\n", awt, atat);
}
