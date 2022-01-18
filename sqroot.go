func mySqrt(x int) int {
    start := 0
    end := x

    for start <= end {
		middle := start + ( end - start )/2
		if middle * middle > x {
			end = middle - 1
		} else if (middle + 1)*( middle + 1) > x {
			return middle
		} else {
			start = middle + 1
		}
	}

    return start
}