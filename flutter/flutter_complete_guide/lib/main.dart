import 'package:flutter/material.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  //const MyApp({Key? key}) : super(key: key);

  void answerQuestion() {
    print('Answer chosen');
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        home: Scaffold(
            appBar: AppBar(
              title: Text('My First App'),
            ),
            body: Column(
              children: [
                Text('The Question is ...'),
                RaisedButton(
                  child: Text('Answer 1'),
                  onPressed: answerQuestion,
                ),
                RaisedButton(
                  child: Text('Answer 2'),
                  onPressed: answerQuestion,
                ),
                RaisedButton(
                  child: Text('Answer 3'),
                  onPressed:
                      answerQuestion, //NOTE: pointer to fun, not return value of fun
                ),
              ],
            )));
  }
}
