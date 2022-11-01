import time

# Solution 1: bruteforcing; not efficient
start_time = time.perf_counter()
summation = 0
for i in range(1, 1000):
    if i % 3 == 0 or i % 5 == 0:
        summation += i
print("- Solution 1 -")
print("RESULT: {}".format(summation))
exec_time = round((time.perf_counter()-start_time) * (10**6), 1)
print("TIME: {}ms".format(exec_time))

print()

# Solution 3: arithmetic approach; efficient
start_time = time.perf_counter()
def sum_divisible_by(n, p):
    return n*(p//n)*((p//n)+1)//2
print("- Solution 2 -")
print("RESULT: {}".format(sum_divisible_by(3, 999) + sum_divisible_by(5, 999) - sum_divisible_by(15, 999)))
exec_time = round((time.perf_counter()-start_time) * (10**6), 1)
print("TIME: {}ms".format(exec_time))
