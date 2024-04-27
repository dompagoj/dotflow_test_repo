def run() {
    stage("Hello") {
        echo "Test 123"
    }

    stage("cleanum") {
        echo "Cleanup"
    }
}
return this
