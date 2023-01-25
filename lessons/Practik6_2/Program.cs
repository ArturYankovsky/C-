double test(double[] array)
{
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i ++){
if (min > array[i])
min = array[i];
if (array[i] > max)
max = array[i];
}

foreach (double i in array){
if (min > i)
min = i;
if (i > max)
max = i;
}
return max - min;
}
