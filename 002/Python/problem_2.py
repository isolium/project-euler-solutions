import time

# Solution 1: calculating Fibonacci series and testing for even values;
# not efficient
start_time = time.perf_counter()
a = b = 1
c = a + b
summation = 0
while (c < 4000000):
    if c % 2 == 0: summation += c
    a = b
    b = c
    c = a + b
print("- Solution 1 -")
print("RESULT: {}".format(summation))
exec_time = round((time.perf_counter()-start_time) * (10**3), 1)
print("TIME: {}ms".format(exec_time))

print()

# Solution 2: calculating every third value of the series. that is,
# the even values; more efficient
start_time = time.perf_counter()
x = y = 1
summation = 0
while ((x + y) < 4000000):
    summation += (x + y)
    x, y = x + 2 * y, 2 * x + 3 * y
print("- Solution 2 -")
print("RESULT: {}".format(summation))
exec_time = round((time.perf_counter()-start_time) * (10**3), 1)
print("TIME: {}ms".format(exec_time))
