pipeline {
    agent any

    stages {
        // stage('Checkout') {
        //     steps {
        //         git 'https://github.com/Mike-Guidry/JenkinsTest.git'
        //     }
        // }
        stage('Build') {
            steps {
                bat 'dotnet build -c Release'
            }
        }
        stage('Test') {
            steps {
                bat 'if exist "JenkinsAppTests/TestResults/" rmdir /s /q "JenkinsAppTests/TestResults"'
                bat 'dotnet test JenkinsAppTests/JenkinsAppTests.csproj --logger trx'
            }
            post {
                always {
                    mstest()
                }
            }
        }
        stage('Deploy Dev') {
			when { branch 'development' }
            steps {
                input('Deploy to dev?')
                echo 'deploy to dev...'
            }
        }
        stage('Deploy Test') {
			when { branch 'development' }
            steps {
                input('Deploy to test?')
                echo 'deploy to test...'
            }
        }
		stage('Deploy Prod') {
			when { branch 'master' }
            steps {
                input('Deploy to prod?')
				echo 'deploy to prod...'
            }
        }
    }
}
