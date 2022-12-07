#a
stream = input()

for i in range(len(stream)):
    cache = stream[i:i+14]
    for c in range(len(cache)):
        currentChar = cache[c]
        cache = cache.replace(currentChar, " ", 1)
        if currentChar in cache:
            break
    else:
        print(i+14)
        break

