function c(n) {
    n = parseInt(n)
    if (!n) {
        return 1/2
    }
    else {
        return (((2 * ((2 * n) - 1)) / (n + 1)) * c(n-1))
    }
}