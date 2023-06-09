N = int(input())
C = []
V = []
for i in range(N):
    C.append(str(input()))
    V.append(int(input()))
Vm = max(V)
for a in V:
    if a == Vm:
        P = V.index(a)
print(C[P])
print(V[P])