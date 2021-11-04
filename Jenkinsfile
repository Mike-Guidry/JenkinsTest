pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                bat """
					echo "Line 1"
					dir
					echo "Hi There!"
				"""
				bat "npm --version"
            }
        }
    }
}