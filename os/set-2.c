// TASK-1************************************************************

// #include <stdio.h>
// #include <unistd.h>
// #include <sys/types.h>
// #include <sys/stat.h>
// #include <fcntl.h>
// void main()
// {
//     int fd1, fd2, n = 1;
//     char *buf;
//     fd1 = open("f1", O_RDONLY);
//     fd2 = open("f2", O_WRONLY | O_CREAT, S_IWUSR | S_IRUSR);
//     if ((fd1 == -1) || (fd2 == -1))
//         printf("error");
//     else
//     {
//         while (n > 0)
//         {
//             n = read(fd1, &buf, 1);
//             write(fd2, &buf, 1);
//         }
//     }
// }





// TASK-2************************************************************

#include <stdio.h>
void main()
{
    int np, ps, pt[20], nf, la, pn, index, pa, i, j;
    printf("\n enter number of pages:");
    scanf("%d", &np);
    printf("\n enter page size");
    scanf("%d", &ps);
    printf("\n enter page table");
    for (i = 0; i < np; i++)
        scanf("%d", &pt[i]);
    printf("\n enter number of frames:");
    scanf("%d", &nf);
    printf("\n enter logical address");
    scanf("%d", &la);
    pn = la / ps;
    index = la % ps;
    pa = (pt[pn] + ps) + index;
    printf("\n physical address is %d", pa);
}
