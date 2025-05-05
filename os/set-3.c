// TASK-1************************************************************




#include <stdio.h>
int main()
{
    int p[10];
    int tat[10], wt[10], i, n, pt[10], bt[10];
    float avg = 0, tot = 0;
    printf("enter no of processes:");
    scanf("%d", &n);
    for (i = 0; i < n; i++)
    {
        printf("enter process%d number:\n", i + 1);
        scanf("%d", &p[i]);
        printf("enter process time");
        scanf("%d", &pt[i]);
    }
    wt[0] = 0;
    for (i = 1; i < n; i++)
    {
        wt[i] = pt[i - 1] + wt[i - 1];
        tot = tot + wt[i];
    }
    avg = (float)tot / n;
    for (i = 0; i < n; i++)
        tat[i] = pt[i] + wt[i];
    printf("p_number\t P_time\t w_time\t turn around time\n");
    for (i = 0; i < n; i++)
        printf("%d\t%d\t%d\t%d\n", p[i], pt[i], wt[i], tat[i]);
    printf("total waiting time=%f\n avg waiting time=%f", tot, avg);
    return 0;
}




